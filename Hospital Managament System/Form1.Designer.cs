namespace Hospital_Managament_System
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
            this.lbllogo = new System.Windows.Forms.Label();
            this.lblUn = new System.Windows.Forms.Label();
            this.lblPd = new System.Windows.Forms.Label();
            this.tbxUn = new System.Windows.Forms.TextBox();
            this.tbxPd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNurseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReceptionistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbllogo.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.Location = new System.Drawing.Point(187, 9);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(574, 49);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "Hospital Management System";
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUn.Location = new System.Drawing.Point(189, 114);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(152, 32);
            this.lblUn.TabIndex = 1;
            this.lblUn.Text = "Username";
            // 
            // lblPd
            // 
            this.lblPd.AutoSize = true;
            this.lblPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPd.Location = new System.Drawing.Point(189, 181);
            this.lblPd.Name = "lblPd";
            this.lblPd.Size = new System.Drawing.Size(154, 32);
            this.lblPd.TabIndex = 2;
            this.lblPd.Text = "Password ";
            // 
            // tbxUn
            // 
            this.tbxUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUn.Location = new System.Drawing.Point(571, 114);
            this.tbxUn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUn.Name = "tbxUn";
            this.tbxUn.Size = new System.Drawing.Size(235, 34);
            this.tbxUn.TabIndex = 3;
            // 
            // tbxPd
            // 
            this.tbxPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPd.Location = new System.Drawing.Point(571, 181);
            this.tbxPd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPd.Name = "tbxPd";
            this.tbxPd.Size = new System.Drawing.Size(235, 34);
            this.tbxPd.TabIndex = 11;
            this.tbxPd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLogin.Location = new System.Drawing.Point(196, 257);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(147, 53);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegister.Location = new System.Drawing.Point(571, 257);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 53);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Aqua;
            this.lblDisplay.Location = new System.Drawing.Point(191, 350);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(221, 49);
            this.lblDisplay.TabIndex = 14;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 32);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.addNurseToolStripMenuItem,
            this.addPatientToolStripMenuItem,
            this.addReceptionistToolStripMenuItem,
            this.addTechnicianToolStripMenuItem,
            this.viewRecordsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // addNurseToolStripMenuItem
            // 
            this.addNurseToolStripMenuItem.Name = "addNurseToolStripMenuItem";
            this.addNurseToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addNurseToolStripMenuItem.Text = "Add Nurse";
            this.addNurseToolStripMenuItem.Click += new System.EventHandler(this.addNurseToolStripMenuItem_Click);
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // addReceptionistToolStripMenuItem
            // 
            this.addReceptionistToolStripMenuItem.Name = "addReceptionistToolStripMenuItem";
            this.addReceptionistToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addReceptionistToolStripMenuItem.Text = "Add Receptionist";
            this.addReceptionistToolStripMenuItem.Click += new System.EventHandler(this.addReceptionistToolStripMenuItem_Click);
            // 
            // addTechnicianToolStripMenuItem
            // 
            this.addTechnicianToolStripMenuItem.Name = "addTechnicianToolStripMenuItem";
            this.addTechnicianToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addTechnicianToolStripMenuItem.Text = "Add Technician";
            this.addTechnicianToolStripMenuItem.Click += new System.EventHandler(this.addTechnicianToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRecordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPd);
            this.Controls.Add(this.tbxUn);
            this.Controls.Add(this.lblPd);
            this.Controls.Add(this.lblUn);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.Label lblPd;
        private System.Windows.Forms.TextBox tbxUn;
        private System.Windows.Forms.TextBox tbxPd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNurseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReceptionistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

