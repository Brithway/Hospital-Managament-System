namespace Hospital_Managament_System
{
    partial class View
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
            this.dgvHospital = new System.Windows.Forms.DataGridView();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnAR = new System.Windows.Forms.Button();
            this.BtnGR = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHospital
            // 
            this.dgvHospital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospital.Location = new System.Drawing.Point(12, 199);
            this.dgvHospital.Name = "dgvHospital";
            this.dgvHospital.RowHeadersWidth = 51;
            this.dgvHospital.RowTemplate.Height = 24;
            this.dgvHospital.Size = new System.Drawing.Size(1020, 369);
            this.dgvHospital.TabIndex = 0;
            // 
            // cboData
            // 
            this.cboData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "All Doctors",
            "All Nurses",
            "All Patients",
            "All Technician",
            "Male Nurses",
            "Patients Above 25",
            "Technician By Department"});
            this.cboData.Location = new System.Drawing.Point(260, 106);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(369, 33);
            this.cboData.TabIndex = 1;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(342, 36);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(197, 64);
            this.BtnSubmit.TabIndex = 2;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(27, 39);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(209, 58);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAR
            // 
            this.BtnAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAR.Location = new System.Drawing.Point(655, 36);
            this.BtnAR.Name = "BtnAR";
            this.BtnAR.Size = new System.Drawing.Size(171, 61);
            this.BtnAR.TabIndex = 4;
            this.BtnAR.Text = "All Receptionist";
            this.BtnAR.UseVisualStyleBackColor = true;
            this.BtnAR.Click += new System.EventHandler(this.BtnAR_Click);
            // 
            // BtnGR
            // 
            this.BtnGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGR.Location = new System.Drawing.Point(655, 117);
            this.BtnGR.Name = "BtnGR";
            this.BtnGR.Size = new System.Drawing.Size(171, 61);
            this.BtnGR.TabIndex = 5;
            this.BtnGR.Text = "Get Receptionist";
            this.BtnGR.UseVisualStyleBackColor = true;
            this.BtnGR.Click += new System.EventHandler(this.BtnGR_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(27, 114);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(209, 64);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Managament_System.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(874, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnGR);
            this.Controls.Add(this.BtnAR);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.cboData);
            this.Controls.Add(this.dgvHospital);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospital;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnAR;
        private System.Windows.Forms.Button BtnGR;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}