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
    public partial class Doctor : Form
    {
        // Constructor for initializing the form
        public Doctor()
        {
            InitializeComponent(); // Initializes the form components (e.g., buttons, textboxes, etc.)
        }

        // Event handler for the "Exit" button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form1 and display it
            Form1 form1 = new Form1();
            form1.ShowDialog(); // Show Form1 as a dialog, meaning the current form is paused until it's closed
        }

        // Event handler for the "Submit" button click event
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
            decimal py = decimal.Parse(tbxPay.Text); // Convert the pay from textbox to a decimal

            // Create an instance of the AddDoctor class and pass the entered details
            AddDoctor addDoctor = new AddDoctor(ne, ad, cy, ag, ph, em, se, dt, py);

            // Call the method to add the new doctor to the database
            addDoctor.AddNewDoctor();

            // Clear all input fields after the doctor information is submitted
            tbxName.Clear();
            tbxAddress.Clear();
            tbxPhone.Clear();
            tbxEmail.Clear();
            tbxPay.Clear();
            tbxAge.Clear();
            tbxStaffCode.Clear();

             
        }
    }
}
