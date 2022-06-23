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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPSK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPeerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.listmsgs = new System.Windows.Forms.ListBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPSK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(387, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textPSK
            // 
            this.textPSK.Location = new System.Drawing.Point(125, 107);
            this.textPSK.Margin = new System.Windows.Forms.Padding(4);
            this.textPSK.Name = "textPSK";
            this.textPSK.PasswordChar = '*';
            this.textPSK.Size = new System.Drawing.Size(219, 28);
            this.textPSK.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "PSK";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(125, 70);
            this.textLocalPort.Margin = new System.Windows.Forms.Padding(4);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(219, 28);
            this.textLocalPort.TabIndex = 1;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(125, 36);
            this.textLocalIp.Margin = new System.Windows.Forms.Padding(4);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(219, 28);
            this.textLocalIp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPeerName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(401, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peer";
            // 
            // textPeerName
            // 
            this.textPeerName.Location = new System.Drawing.Point(139, 105);
            this.textPeerName.Margin = new System.Windows.Forms.Padding(4);
            this.textPeerName.Name = "textPeerName";
            this.textPeerName.Size = new System.Drawing.Size(219, 28);
            this.textPeerName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Alias";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(139, 68);
            this.textRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(219, 28);
            this.textRemotePort.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(139, 34);
            this.textRemoteIp.Margin = new System.Windows.Forms.Padding(4);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(219, 28);
            this.textRemoteIp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(712, 174);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // listmsgs
            // 
            this.listmsgs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listmsgs.FormattingEnabled = true;
            this.listmsgs.ItemHeight = 24;
            this.listmsgs.Location = new System.Drawing.Point(19, 224);
            this.listmsgs.Margin = new System.Windows.Forms.Padding(4);
            this.listmsgs.Name = "listmsgs";
            this.listmsgs.Size = new System.Drawing.Size(793, 340);
            this.listmsgs.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsg.Location = new System.Drawing.Point(124, 590);
            this.textMsg.Margin = new System.Windows.Forms.Padding(4);
            this.textMsg.MaxLength = 47;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(381, 28);
            this.textMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Blue;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(533, 586);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Teal;
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(712, 586);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 35);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 593);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type here:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(546, 181);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 21);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Pending";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 645);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.listmsgs);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ency Messenger";
            this.Load += new System.EventHandler(this.Chat_Load);
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox listmsgs;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textPSK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textPeerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

