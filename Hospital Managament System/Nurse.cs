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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }
        // Event handler for the "Exit" button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Event handler for the "Exit" button click event
            Form1 form1 = new Form1();
            form1.ShowDialog(); // Show Form1 as a dialog (pauses the current form until it's closed)
        }

        // Event handler for the "Submit" button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve values entered by the user in the form's input fields
            string ne = tbxName.Text;
            string ad = tbxAddress.Text;
            string cy = cbxCounty.Text;
            int ag = int.Parse(tbxAge.Text);
            string ph = tbxPhone.Text;
            string em = tbxEmail.Text;
            string se = tbxStaffCode.Text;
            string dt = cbxDepartment.Text;
            string ge = "Male";
            if (rdbFemale.Checked)
                ge = "Female";
            string hr = tbxHours.Text;

            // Create an instance of the AddNurse class, passing all the entered details
            AddNurse addNurse = new AddNurse(ne, ad, cy, ag, ph, em, se, dt, hr, ge);

            // Call the method to add the new nurse to the data store
            addNurse.AddNewNurse();

            // Clear all the input fields after the nurse's information is submitted
            tbxName.Clear();
            tbxAddress.Clear();
            tbxPhone.Clear();
            tbxEmail.Clear();
            tbxAge.Clear();
            tbxHours.Clear();
            tbxPhone.Clear();
            tbxStaffCode.Clear();

        }
    }
}
