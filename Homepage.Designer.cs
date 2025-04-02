namespace Forms_project
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.LblClientID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtClientID = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.ChkBxShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClientID
            // 
            this.LblClientID.AutoSize = true;
            this.LblClientID.Location = new System.Drawing.Point(183, 120);
            this.LblClientID.Name = "LblClientID";
            this.LblClientID.Size = new System.Drawing.Size(70, 20);
            this.LblClientID.TabIndex = 0;
            this.LblClientID.Text = "ClientID:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(171, 160);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(82, 20);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password:";
            // 
            // TxtClientID
            // 
            this.TxtClientID.Location = new System.Drawing.Point(278, 117);
            this.TxtClientID.Name = "TxtClientID";
            this.TxtClientID.Size = new System.Drawing.Size(240, 26);
            this.TxtClientID.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(278, 157);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(240, 26);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // PctLogo
            // 
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(12, 352);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(193, 87);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogo.TabIndex = 4;
            this.PctLogo.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(474, 252);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(163, 54);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.BackColor = System.Drawing.Color.White;
            this.BtnCreateUser.Location = new System.Drawing.Point(598, 369);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(170, 56);
            this.BtnCreateUser.TabIndex = 6;
            this.BtnCreateUser.Text = "Create user";
            this.BtnCreateUser.UseVisualStyleBackColor = false;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // ChkBxShowPass
            // 
            this.ChkBxShowPass.AutoSize = true;
            this.ChkBxShowPass.Location = new System.Drawing.Point(446, 203);
            this.ChkBxShowPass.Name = "ChkBxShowPass";
            this.ChkBxShowPass.Size = new System.Drawing.Size(147, 24);
            this.ChkBxShowPass.TabIndex = 7;
            this.ChkBxShowPass.Text = "Show password";
            this.ChkBxShowPass.UseVisualStyleBackColor = true;
            this.ChkBxShowPass.CheckedChanged += new System.EventHandler(this.ChkBxShowPass_CheckedChanged);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkBxShowPass);
            this.Controls.Add(this.BtnCreateUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PctLogo);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtClientID);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblClientID);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClientID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtClientID;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.CheckBox ChkBxShowPass;
    }
}

