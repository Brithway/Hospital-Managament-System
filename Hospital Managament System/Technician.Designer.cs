namespace Hospital_Managament_System
{
    partial class Technician
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
            this.grpDoctor = new System.Windows.Forms.GroupBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCounty = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxStaffCode = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxCert = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblCert = new System.Windows.Forms.Label();
            this.lblStaffCode = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbllogo = new System.Windows.Forms.Label();
            this.grpDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDoctor
            // 
            this.grpDoctor.Controls.Add(this.cbxDepartment);
            this.grpDoctor.Controls.Add(this.pictureBox1);
            this.grpDoctor.Controls.Add(this.cbxCounty);
            this.grpDoctor.Controls.Add(this.btnExit);
            this.grpDoctor.Controls.Add(this.btnSubmit);
            this.grpDoctor.Controls.Add(this.tbxStaffCode);
            this.grpDoctor.Controls.Add(this.tbxPhone);
            this.grpDoctor.Controls.Add(this.tbxEmail);
            this.grpDoctor.Controls.Add(this.tbxAddress);
            this.grpDoctor.Controls.Add(this.tbxCert);
            this.grpDoctor.Controls.Add(this.tbxAge);
            this.grpDoctor.Controls.Add(this.tbxName);
            this.grpDoctor.Controls.Add(this.lblCert);
            this.grpDoctor.Controls.Add(this.lblStaffCode);
            this.grpDoctor.Controls.Add(this.lblDepartment);
            this.grpDoctor.Controls.Add(this.lblCounty);
            this.grpDoctor.Controls.Add(this.lblPhone);
            this.grpDoctor.Controls.Add(this.label4);
            this.grpDoctor.Controls.Add(this.lblEmail);
            this.grpDoctor.Controls.Add(this.lblAddress);
            this.grpDoctor.Controls.Add(this.lblName);
            this.grpDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctor.Location = new System.Drawing.Point(7, 52);
            this.grpDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.grpDoctor.Name = "grpDoctor";
            this.grpDoctor.Padding = new System.Windows.Forms.Padding(4);
            this.grpDoctor.Size = new System.Drawing.Size(1021, 506);
            this.grpDoctor.TabIndex = 27;
            this.grpDoctor.TabStop = false;
            this.grpDoctor.Text = "Technician";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Cardiology\t",
            "Neurology\t",
            "Pediatrics",
            "General Surgery\t",
            "Orthopedics\t",
            "Obstetrics and Gynecology\t",
            "Emergency Medicine\t",
            "Radiology\t",
            "Oncology\t",
            "Anesthesiology\t ",
            "Dermatology\t",
            "Psychiatry\t",
            "Pathology\t",
            "Gastroenterology\t",
            "Nephrology\t",
            "Urology\t",
            "Pulmonology\t",
            "Endocrinology\t",
            "Rheumatology\t",
            "Ophthalmology\t",
            "ENT (Ear, Nose, and Throat)\t",
            "Geriatrics",
            "Hematology\t",
            "Plastic Surgery\t",
            "Infectious Diseases\t",
            "Physical Medicine/Rehabilitation\t ",
            "Critical Care/ICU\t",
            "Neonatology\t",
            "Family Medicine\t",
            "Allergy and Immunology"});
            this.cbxDepartment.Location = new System.Drawing.Point(191, 265);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(381, 37);
            this.cbxDepartment.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Managament_System.Properties.Resources.handyman;
            this.pictureBox1.Location = new System.Drawing.Point(672, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCounty
            // 
            this.cbxCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCounty.FormattingEnabled = true;
            this.cbxCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbxCounty.Location = new System.Drawing.Point(191, 182);
            this.cbxCounty.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCounty.Name = "cbxCounty";
            this.cbxCounty.Size = new System.Drawing.Size(291, 37);
            this.cbxCounty.TabIndex = 42;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(331, 403);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 54);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(36, 403);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(170, 54);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxStaffCode
            // 
            this.tbxStaffCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffCode.Location = new System.Drawing.Point(772, 265);
            this.tbxStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStaffCode.Name = "tbxStaffCode";
            this.tbxStaffCode.Size = new System.Drawing.Size(207, 34);
            this.tbxStaffCode.TabIndex = 39;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(683, 180);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(296, 34);
            this.tbxPhone.TabIndex = 38;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(611, 119);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(368, 34);
            this.tbxEmail.TabIndex = 37;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(611, 30);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(368, 34);
            this.tbxAddress.TabIndex = 36;
            // 
            // tbxCert
            // 
            this.tbxCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCert.Location = new System.Drawing.Point(191, 334);
            this.tbxCert.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCert.Name = "tbxCert";
            this.tbxCert.Size = new System.Drawing.Size(291, 34);
            this.tbxCert.TabIndex = 35;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.Location = new System.Drawing.Point(191, 101);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(97, 34);
            this.tbxAge.TabIndex = 33;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(191, 27);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(267, 34);
            this.tbxName.TabIndex = 32;
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCert.Location = new System.Drawing.Point(31, 339);
            this.lblCert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(153, 29);
            this.lblCert.TabIndex = 31;
            this.lblCert.Text = "Certification";
            // 
            // lblStaffCode
            // 
            this.lblStaffCode.AutoSize = true;
            this.lblStaffCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCode.Location = new System.Drawing.Point(606, 265);
            this.lblStaffCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffCode.Name = "lblStaffCode";
            this.lblStaffCode.Size = new System.Drawing.Size(135, 29);
            this.lblStaffCode.TabIndex = 30;
            this.lblStaffCode.Text = "Staff Code";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(31, 268);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(148, 29);
            this.lblDepartment.TabIndex = 29;
            this.lblDepartment.Text = "Department";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(31, 180);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(93, 29);
            this.lblCounty.TabIndex = 28;
            this.lblCounty.Text = "County";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(530, 185);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 29);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Age";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(493, 122);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 29);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(493, 33);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 29);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.SystemColors.Menu;
            this.lbllogo.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbllogo.Location = new System.Drawing.Point(174, -1);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(574, 49);
            this.lbllogo.TabIndex = 26;
            this.lbllogo.Text = "Hospital Management System";
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 557);
            this.Controls.Add(this.grpDoctor);
            this.Controls.Add(this.lbllogo);
            this.Name = "Technician";
            this.Text = "Technician";
            this.grpDoctor.ResumeLayout(false);
            this.grpDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDoctor;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCounty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxStaffCode;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxCert;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.Label lblStaffCode;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbllogo;
    }
}