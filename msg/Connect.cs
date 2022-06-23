using System;
using System.Windows.Forms;

namespace msg
{
    public partial class Connect : Form
    {
        public static string remoteIP = "";
        public static string remotePort = "";
        public static string peerName = "";

        public Connect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            remoteIP = txtRemoteIp.Text;
            remotePort = txtRemotePort.Text;
            peerName = txtPort.Text;
            Form1 form = new Form1(remoteIP, remotePort, peerName);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
