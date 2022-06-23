using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace msg
{
    public partial class Login : Form
    {
        EncyDency ency = new EncyDency();
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; port = 3306; Initial Catalog = ency_chat; User Id = root; password = ''");
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String usn = txtUsn.Text;
            String pwd = txtPwd.Text;
            String confirmPwd = txtConfirmPwd.Text;
            String datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if ( pwd.Equals(confirmPwd) && !usn.Equals("") && !pwd.Equals("") && usn.Length > 3 && pwd.Length > 3)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO `login` (`id`, `username`, `password`, `datetime`) VALUES (NULL, '" + ency.EncryptText(usn, "4N-OI~JC") + "', '" + ency.EncryptText(pwd, "F6pcE[7|") + "', '"+ datetime +"');";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Sigend Up", "Success", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    
                    Connect cn = new Connect();
                    cn.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {                   
                    MessageBox.Show("Data Insert Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Equals("") && !txtPassword.Equals(""))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM `login` WHERE `username` = '" + ency.EncryptText(txtUsername.Text, "4N-OI~JC") + "' and `password` = '" + ency.EncryptText(txtPassword.Text, "F6pcE[7|") + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    int i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Invalid Credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Connect cn = new Connect();
                        cn.Show();
                        this.Hide();
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Data Search Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Blanks Are Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsn.Text = "";
            txtPwd.Text = "";
            txtConfirmPwd.Text = "";
        }
    }
}
