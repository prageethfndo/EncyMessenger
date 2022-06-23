namespace msg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.listmsgs = new System.Windows.Forms.ListBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(323, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(95, 70);
            this.textLocalPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(219, 22);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(95, 36);
            this.textLocalIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(219, 22);
            this.textLocalIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(377, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(367, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(103, 75);
            this.textRemotePort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(219, 22);
            this.textRemotePort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(103, 41);
            this.textRemoteIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(219, 22);
            this.textRemoteIp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(771, 53);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // listmsgs
            // 
            this.listmsgs.FormattingEnabled = true;
            this.listmsgs.ItemHeight = 16;
            this.listmsgs.Location = new System.Drawing.Point(16, 173);
            this.listmsgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listmsgs.Name = "listmsgs";
            this.listmsgs.Size = new System.Drawing.Size(855, 228);
            this.listmsgs.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(240, 441);
            this.textMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textMsg.MaxLength = 47;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(403, 22);
            this.textMsg.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(668, 438);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 113);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(771, 122);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 28);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type here; ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(797, 93);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 512);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.listmsgs);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox listmsgs;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
    }
}

