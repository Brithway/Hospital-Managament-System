using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Hospital_Managament_System
{
    public partial class Form1 : Form
    {
        // Instantiate helper objects for hash generation and database operations.
        Hashcode hs = new Hashcode();
        DAO dao = new DAO();

        // Constructor for the form. Initializes the UI components.
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the Login button click event.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve the username and hash the password input using the Passhash method.
            string Username = tbxUn.Text;
            string Password = hs.Passhash(tbxPd.Text);

            SqlDataReader dr = null; // To hold the result of the database query.

            // Create a SQL command object using the DAO's open connection.
            SqlCommand cmd = dao.OpenCon().CreateCommand();

            // Specify the stored procedure for login.
            cmd.CommandText = "usplogin";
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parameters to the SQL command for the username and password.
            cmd.Parameters.AddWithValue("@Un", Username);
            cmd.Parameters.AddWithValue("@Pd", Password);

            // Execute the command and retrieve results.
            dr = cmd.ExecuteReader();

            // Check if the reader contains any data (indicating successful login).
            if (dr.Read())
            {
                // Inform the user of a successful login.
                MessageBox.Show("You Are Logged in");

                // Clear the input fields.
                tbxUn.Clear();
                tbxPd.Clear();

                // Display the logged-in user's name.
                Name = Username;
                lblDisplay.Text = "Welcome " + Name;

                // Disable login-related UI elements after successful login.
                lblPd.Enabled = false;
                lblUn.Enabled = false;
                tbxPd.Enabled = false;
                tbxUn.Enabled = false;
                btnRegister.Enabled = false;
                btnLogin.Enabled = false;
         
            }
            else
            {
                // Inform the user of an invalid login attempt.
                MessageBox.Show("Invalid");
            }
            // Close the database connection after the operation.
            dao.CloseCon();

        }

        // Event handler for the Register button click event.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the Register form as a dialog.
            Register register = new Register();
            register.ShowDialog();
        }

        // Event handler for the "Add Doctor" menu item click event
        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Doctor form.
            Doctor doctor = new Doctor();

            // Display the Doctor form as a modal dialog.
            doctor.ShowDialog();
        }

        // Event handler for the "Add Nurse" menu item click event.
        private void addNurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Nurse form.
            Nurse nurse = new Nurse();

            // Display the Nurse form as a modal dialog.
            nurse.ShowDialog();
        }

        // Event handler for the "Add Patient" menu item click event.
        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Patient form.
            Patient patient = new Patient();

            // Display the Patient form as a modal dialog.
            patient.ShowDialog();
        }


        // Event handler for the "Add Receptionist" menu item click event.
        private void addReceptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Receptionist form.
            Receptionist receptionist = new Receptionist();

            // Display the Technician form as a modal dialog.
            receptionist.ShowDialog();
        }

        // Event handler for the "View Records" menu item click event.
        private void addTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the View form.
            Technician technician = new Technician();

            // Display the View form as a modal dialog to show records.
            technician.ShowDialog();
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.ShowDialog();
        }

        // Event handler for the "Exit" menu item click event.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form to exit the application.
            this.Close();
        }
    }
}
