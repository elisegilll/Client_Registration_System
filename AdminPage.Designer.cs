namespace Forms_project
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnSaveToFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtEnterClientID = new System.Windows.Forms.TextBox();
            this.BtnSearchClientID = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmboBxSortBy = new System.Windows.Forms.ComboBox();
            this.DtaGridClient = new System.Windows.Forms.DataGridView();
            this.ClientSystemDataSet = new Forms_project.ClientSystemDataSet();
            this.clientSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Forms_project.ClientSystemDataSetTableAdapters.ClientTableAdapter();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // PctLogo
            // 
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(12, 410);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(193, 87);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.White;
            this.BtnLogOut.Location = new System.Drawing.Point(554, 12);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(198, 55);
            this.BtnLogOut.TabIndex = 1;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnSaveToFile
            // 
            this.BtnSaveToFile.BackColor = System.Drawing.Color.White;
            this.BtnSaveToFile.Location = new System.Drawing.Point(545, 420);
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Size = new System.Drawing.Size(191, 56);
            this.BtnSaveToFile.TabIndex = 2;
            this.BtnSaveToFile.Text = "Save data to file";
            this.BtnSaveToFile.UseVisualStyleBackColor = false;
            this.BtnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtEnterClientID);
            this.groupBox1.Controls.Add(this.BtnSearchClientID);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by ClientID:";
            // 
            // TxtEnterClientID
            // 
            this.TxtEnterClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnterClientID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtEnterClientID.Location = new System.Drawing.Point(19, 39);
            this.TxtEnterClientID.Name = "TxtEnterClientID";
            this.TxtEnterClientID.Size = new System.Drawing.Size(162, 26);
            this.TxtEnterClientID.TabIndex = 6;
            this.TxtEnterClientID.TextChanged += new System.EventHandler(this.TxtEnterClientID_TextChanged);
            // 
            // BtnSearchClientID
            // 
            this.BtnSearchClientID.BackColor = System.Drawing.Color.White;
            this.BtnSearchClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchClientID.Location = new System.Drawing.Point(201, 30);
            this.BtnSearchClientID.Name = "BtnSearchClientID";
            this.BtnSearchClientID.Size = new System.Drawing.Size(126, 41);
            this.BtnSearchClientID.TabIndex = 6;
            this.BtnSearchClientID.Text = "Search";
            this.BtnSearchClientID.UseVisualStyleBackColor = false;
            this.BtnSearchClientID.Click += new System.EventHandler(this.BtnSearchClientID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmboBxSortBy);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort by:";
            // 
            // CmboBxSortBy
            // 
            this.CmboBxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboBxSortBy.FormattingEnabled = true;
            this.CmboBxSortBy.Items.AddRange(new object[] {
            "ClientID\t\t",
            "Name"});
            this.CmboBxSortBy.Location = new System.Drawing.Point(64, 37);
            this.CmboBxSortBy.Name = "CmboBxSortBy";
            this.CmboBxSortBy.Size = new System.Drawing.Size(205, 28);
            this.CmboBxSortBy.TabIndex = 0;
            this.CmboBxSortBy.SelectedIndexChanged += new System.EventHandler(this.CmboBxSortBy_SelectedIndexChanged);
            // 
            // DtaGridClient
            // 
            this.DtaGridClient.AllowUserToAddRows = false;
            this.DtaGridClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.DtaGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaGridClient.Location = new System.Drawing.Point(28, 196);
            this.DtaGridClient.Name = "DtaGridClient";
            this.DtaGridClient.ReadOnly = true;
            this.DtaGridClient.RowHeadersWidth = 62;
            this.DtaGridClient.RowTemplate.Height = 28;
            this.DtaGridClient.Size = new System.Drawing.Size(740, 184);
            this.DtaGridClient.TabIndex = 5;
            this.DtaGridClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridClient_CellContentClick);
            // 
            // clientSystemDataSet
            // 
            this.ClientSystemDataSet.DataSetName = "ClientSystemDataSet";
            this.ClientSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientSystemDataSetBindingSource
            // 
            this.clientSystemDataSetBindingSource.DataSource = this.ClientSystemDataSet;
            this.clientSystemDataSetBindingSource.Position = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.clientSystemDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.clientSystemDataSetBindingSource;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.clientSystemDataSetBindingSource;
            // 
            // clientBindingSource3
            // 
            this.clientBindingSource3.DataMember = "Client";
            this.clientBindingSource3.DataSource = this.clientSystemDataSetBindingSource;
            // 
            // clientBindingSource4
            // 
            this.clientBindingSource4.DataMember = "Client";
            this.clientBindingSource4.DataSource = this.clientSystemDataSetBindingSource;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.DtaGridClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSaveToFile);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.PctLogo);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnSaveToFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtaGridClient;
        private System.Windows.Forms.ComboBox CmboBxSortBy;
        private System.Windows.Forms.Button BtnSearchClientID;
        private System.Windows.Forms.TextBox TxtEnterClientID;
        private System.Windows.Forms.BindingSource clientSystemDataSetBindingSource;
        private ClientSystemDataSet ClientSystemDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ClientSystemDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource3;
        private System.Windows.Forms.BindingSource clientBindingSource4;

    }
}