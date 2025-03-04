using System;
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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent(); // Initialize the components of the form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create an instance of Form1
            form1.ShowDialog(); // Display Form1 as a dialog box
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect user input from various textboxes
            string ne = tbxName.Text; // Patient's name
            string ad = tbxAddress.Text; // Patient's address
            string cy = cbxCounty.Text; // Patient's county
            int ag = int.Parse(tbxAge.Text); // Patient's age
            string ph = tbxPhone.Text; // Patient's phone number
            string em = tbxEmail.Text; // Patient's email address
            string pn = tbxPatientNumber.Text; // Patient's unique identifier

            // Create an instance of AddPatient and add a new patient record
            AddPatient addPatient = new AddPatient(ne, ad, cy, ag, ph, em, pn);
            addPatient.AddNewPatient(); // Call the method to save the patient data

            // Clear all input fields after submission
            tbxName.Clear();
            tbxAddress.Clear();
            tbxPhone.Clear();
            tbxEmail.Clear();
            tbxAge.Clear();
            tbxPatientNumber.Clear();
        }

    }
}
