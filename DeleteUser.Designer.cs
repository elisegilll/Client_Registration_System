namespace Forms_project
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.LblClientID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtClientID = new System.Windows.Forms.TextBox();
            this.ChkBxShowPass = new System.Windows.Forms.CheckBox();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
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
            this.LblClientID.Location = new System.Drawing.Point(144, 130);
            this.LblClientID.Name = "LblClientID";
            this.LblClientID.Size = new System.Drawing.Size(147, 20);
            this.LblClientID.TabIndex = 1;
            this.LblClientID.Text = "Enter your ClientID:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(133, 179);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(158, 20);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Enter your password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(313, 176);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(216, 26);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtClientID
            // 
            this.TxtClientID.Location = new System.Drawing.Point(313, 127);
            this.TxtClientID.Name = "TxtClientID";
            this.TxtClientID.Size = new System.Drawing.Size(216, 26);
            this.TxtClientID.TabIndex = 4;
            // 
            // ChkBxShowPass
            // 
            this.ChkBxShowPass.AutoSize = true;
            this.ChkBxShowPass.Location = new System.Drawing.Point(486, 218);
            this.ChkBxShowPass.Name = "ChkBxShowPass";
            this.ChkBxShowPass.Size = new System.Drawing.Size(147, 24);
            this.ChkBxShowPass.TabIndex = 5;
            this.ChkBxShowPass.Text = "Show password";
            this.ChkBxShowPass.UseVisualStyleBackColor = true;
            this.ChkBxShowPass.CheckedChanged += new System.EventHandler(this.ChkBxShowPass_CheckedChanged);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.White;
            this.BtnDeleteUser.Location = new System.Drawing.Point(486, 285);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(183, 58);
            this.BtnDeleteUser.TabIndex = 6;
            this.BtnDeleteUser.Text = "Delete user";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(628, 22);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(150, 48);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.ChkBxShowPass);
            this.Controls.Add(this.TxtClientID);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblClientID);
            this.Controls.Add(this.PctLogo);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.Label LblClientID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtClientID;
        private System.Windows.Forms.CheckBox ChkBxShowPass;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnBack;
    }
}