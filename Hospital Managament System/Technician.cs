﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managament_System
{
    public partial class Technician : Form
    {
        public Technician()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve values entered by the user in the form's input fields
            string ne = tbxName.Text; // Get the doctor's name from the textbox
            string ad = tbxAddress.Text; // Get the doctor's address from the textbox
            string cy = cbxCounty.Text; // Get the selected county from the combobox
            int ag = int.Parse(tbxAge.Text); // Convert the age input from textbox to an integer
            string ph = tbxPhone.Text; // Get the doctor's phone number from the textbox
            string em = tbxEmail.Text; // Get the doctor's email address from the textbox
            string se = tbxStaffCode.Text; // Get the doctor's staff code from the textbox
            string dt = cbxDepartment.Text; // Get the selected department from the combobox
            string ct = tbxCert.Text;

            // Create an instance of AddReceptionist and add a new receptionist record
            AddTechnician addTechnician = new AddTechnician(ne, ad, cy, ag, ph, em, se, dt, ct);
            addTechnician.AddNewTechnician(); // Call the method to save the Receptionist data

            // Clear all input fields after submission
            tbxName.Clear();
            tbxAddress.Clear();
            tbxPhone.Clear();
            tbxEmail.Clear();
            tbxAge.Clear();
            tbxStaffCode.Clear();
            tbxCert.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
