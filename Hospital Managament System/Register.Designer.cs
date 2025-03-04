namespace Hospital_Managament_System
{
    partial class Register
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
            this.txtPd = new System.Windows.Forms.TextBox();
            this.lblPd = new System.Windows.Forms.Label();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.lblFn = new System.Windows.Forms.Label();
            this.lblUn = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbllogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPd
            // 
            this.txtPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPd.Location = new System.Drawing.Point(444, 209);
            this.txtPd.Name = "txtPd";
            this.txtPd.Size = new System.Drawing.Size(205, 38);
            this.txtPd.TabIndex = 14;
            this.txtPd.UseSystemPasswordChar = true;
            // 
            // lblPd
            // 
            this.lblPd.AutoSize = true;
            this.lblPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPd.Location = new System.Drawing.Point(154, 215);
            this.lblPd.Name = "lblPd";
            this.lblPd.Size = new System.Drawing.Size(146, 32);
            this.lblPd.TabIndex = 13;
            this.lblPd.Text = "Password";
            // 
            // txtUn
            // 
            this.txtUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUn.Location = new System.Drawing.Point(444, 148);
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(205, 38);
            this.txtUn.TabIndex = 12;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(444, 93);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(205, 38);
            this.txtFn.TabIndex = 11;
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(154, 99);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(140, 32);
            this.lblFn.TabIndex = 10;
            this.lblFn.Text = "Fullname";
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUn.Location = new System.Drawing.Point(156, 154);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(152, 32);
            this.lblUn.TabIndex = 9;
            this.lblUn.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(162, 283);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(173, 50);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.SystemColors.Control;
            this.lbllogo.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbllogo.Location = new System.Drawing.Point(105, 9);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(581, 51);
            this.lbllogo.TabIndex = 15;
            this.lbllogo.Text = "Hospital Management System";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.txtPd);
            this.Controls.Add(this.lblPd);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblFn);
            this.Controls.Add(this.lblUn);
            this.Controls.Add(this.btnRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPd;
        private System.Windows.Forms.Label lblPd;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbllogo;
    }
}