using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.IO;

namespace msg
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        String pwd;
        String temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get local ip
            textLocalIp.Text = GetLocalIp();
            textRemoteIp.Text = GetLocalIp();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);

            pwd = txtPassword.Text;

            lblStatus.Text = "Connected";           

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            btnConnect.Enabled = false;
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] recData = new byte[1500];
                recData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMsg = aEncoding.GetString(recData);

                listmsgs.Items.Add("Peer: " + receivedMsg);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String encySendingMsg = EncryptText(textMsg.Text, pwd);
            temp = encySendingMsg;
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMsg = new byte[1500];
            sendingMsg = aEncoding.GetBytes(encySendingMsg);

            sck.Send(sendingMsg);

            listmsgs.Items.Add("Me: " + textMsg.Text);
            textMsg.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            bool x = true;
            int c = 24;
            while(x)
            {
                try
                {
                    String msg = listmsgs.SelectedItem.ToString().Split(':')[1].Trim().Substring(0, c);
                    String dencyMsg = DecryptText(msg, pwd);
                    MessageBox.Show(dencyMsg);
                    x = false;
                }
                catch
                {
                    c += 20;
                }
            }
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)                
                    return ip.ToString();               
            }
            return "127.0.0.1";
        }

        public string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }     

        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        //text decrypt
        public string DecryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }

        //decrypt aes
        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }       

    }
}
