namespace Forms_project
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.LblClientID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.TxtClientID = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.ChkBxShowPass = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.RichTextAddress = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PctLogo
            // 
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(12, 352);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(193, 87);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // LblClientID
            // 
            this.LblClientID.AutoSize = true;
            this.LblClientID.Location = new System.Drawing.Point(201, 55);
            this.LblClientID.Name = "LblClientID";
            this.LblClientID.Size = new System.Drawing.Size(70, 20);
            this.LblClientID.TabIndex = 1;
            this.LblClientID.Text = "ClientID:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(189, 96);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(82, 20);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(216, 326);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(52, 20);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Location = new System.Drawing.Point(154, 290);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(117, 20);
            this.LblPhoneNo.TabIndex = 4;
            this.LblPhoneNo.Text = "Phone number:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(199, 201);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(72, 20);
            this.LblAddress.TabIndex = 5;
            this.LblAddress.Text = "Address:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(216, 161);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(55, 20);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Name:";
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.BackColor = System.Drawing.Color.White;
            this.BtnCreateUser.Location = new System.Drawing.Point(557, 361);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(184, 63);
            this.BtnCreateUser.TabIndex = 7;
            this.BtnCreateUser.Text = "Create user";
            this.BtnCreateUser.UseVisualStyleBackColor = false;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // TxtClientID
            // 
            this.TxtClientID.Location = new System.Drawing.Point(294, 52);
            this.TxtClientID.Name = "TxtClientID";
            this.TxtClientID.Size = new System.Drawing.Size(237, 26);
            this.TxtClientID.TabIndex = 8;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(294, 96);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(237, 26);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(294, 158);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 26);
            this.TxtName.TabIndex = 10;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Location = new System.Drawing.Point(294, 287);
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.Size = new System.Drawing.Size(237, 26);
            this.TxtPhoneNo.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(294, 323);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(237, 26);
            this.TxtEmail.TabIndex = 13;
            // 
            // ChkBxShowPass
            // 
            this.ChkBxShowPass.AutoSize = true;
            this.ChkBxShowPass.Location = new System.Drawing.Point(481, 128);
            this.ChkBxShowPass.Name = "ChkBxShowPass";
            this.ChkBxShowPass.Size = new System.Drawing.Size(147, 24);
            this.ChkBxShowPass.TabIndex = 14;
            this.ChkBxShowPass.Text = "Show password";
            this.ChkBxShowPass.UseVisualStyleBackColor = true;
            this.ChkBxShowPass.CheckedChanged += new System.EventHandler(this.ChkBxShowPass_CheckedChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(614, 30);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(138, 44);
            this.BtnBack.TabIndex = 15;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // RichTextAddress
            // 
            this.RichTextAddress.Location = new System.Drawing.Point(294, 198);
            this.RichTextAddress.Name = "RichTextAddress";
            this.RichTextAddress.Size = new System.Drawing.Size(237, 70);
            this.RichTextAddress.TabIndex = 16;
            this.RichTextAddress.Text = "";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextAddress);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChkBxShowPass);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhoneNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtClientID);
            this.Controls.Add(this.BtnCreateUser);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblPhoneNo);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblClientID);
            this.Controls.Add(this.PctLogo);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.Label LblClientID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.TextBox TxtClientID;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPhoneNo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.CheckBox ChkBxShowPass;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.RichTextBox RichTextAddress;
    }
}