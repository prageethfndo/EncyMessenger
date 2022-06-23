using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace msg
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        String psk, remoteIP, remotePort, peerName;
        EncyDency ency = new EncyDency();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(String getRemIp, String getRemPort, String getPeerName)
        {
            remoteIP = getRemIp;
            remotePort = getRemPort;
            peerName = getPeerName;
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get local ip
            textLocalIp.Text = GetLocalIp();
            textPeerName.Text = peerName;
            textRemoteIp.Text = remoteIP;
            textRemotePort.Text = remotePort;
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textLocalPort.Text.Equals("") || textPSK.Text.Equals(""))
            {
                MessageBox.Show("Local Port and PSK could not be empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epRemote);

                psk = textPSK.Text;
                peerName = textPeerName.Text;

                lblStatus.Text = "Connected";
                lblStatus.ForeColor = System.Drawing.Color.Green;

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                btnConfirm.Enabled = false;
                btnSend.Enabled = true;
                btnDecrypt.Enabled = true;
            }         
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] recData = new byte[1500];
                recData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMsg = aEncoding.GetString(recData);

                listmsgs.Items.Add(peerName + " : " + receivedMsg);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MsgCallBack Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textMsg.Text.Equals(""))
            {
                MessageBox.Show("Empty messages are not allowed", "Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String encySendingMsg = ency.EncryptText(textMsg.Text, psk);
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] sendingMsg = new byte[1500];
                sendingMsg = aEncoding.GetBytes(encySendingMsg);

                sck.Send(sendingMsg);

                listmsgs.Items.Add("Me : " + encySendingMsg);
                textMsg.Text = "";
            }            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            bool x = true;
            int c = 24;
            while (x)
            {
                try
                {
                    String msg = listmsgs.SelectedItem.ToString().Split(':')[1].Trim().Substring(0, c);
                    String dencyMsg = ency.DecryptText(msg, psk);
                    MessageBox.Show(dencyMsg, "Decrypted Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
