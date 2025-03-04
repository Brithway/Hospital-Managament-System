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

namespace Hospital_Managament_System
{
    public partial class View : Form
    {
        DAO dao = new DAO(); // DAO instance to manage database connections.

        data d = new data(); // Instance of the data class for executing database operations.

        SqlDataAdapter da; // Used for data retrieval into DataTable.

        DataTable dt; // Holds data retrieved from the database for binding to controls.


        public View()
        {
            InitializeComponent(); // Initializes the form's components.
        }

        private void View_Load(object sender, EventArgs e)
        {
            dgvHospital.DataSource = d.User(); // Loads the user data into the DataGridView when the form loads.
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string selectquery = cboData.SelectedItem.ToString();  // Retrieves the selected query from the ComboBox.
            dt = new DataTable();

            switch (selectquery) // Executes a different method based on the selected option.
            {
                case "All Doctors":
                    dt = d.AllDoctors(); // Fetches all doctors.
                    break;
                case "All Nurses":
                    dt = d.AllNurses(); // Fetches all nurses.
                    break;
                case "All Patients":
                    dt = d.AllPatients(); // Fetches all patients.
                    break;
                case "All Technician":
                    dt = d.AllTechnician(); // Fetches all technicians.
                    break;
                case "Male Nurses":
                    dt = d.MaleNurses(); // Fetches all male nurses.
                    break;
                case "Patients Above 25":
                    dt = d.PatientsAbove25(); // Fetches patients aged above 25.
                    break;
                case "Technician By Department":
                    dt = d.TechnicianByDepartment(); // Fetches technicians by department.
                    break;
            }
            dgvHospital.DataSource = dt; // Updates the DataGridView with the selected query's data.
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvHospital.DataSource = d.User(); // Reloads user data into the DataGridView.
        }

        private void BtnAR_Click(object sender, EventArgs e)
        {
            dgvHospital.DataSource = d.AllReceptionist(); // Fetches and displays all receptionists.
        }

        private void BtnGR_Click(object sender, EventArgs e)
        {
            dgvHospital.DataSource = d.GetReceptionist(); // Fetches a specific receptionist or filtered receptionist data.
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Instantiates the main form.
            form1.ShowDialog(); // Displays the main form as a dialog box.
        }
    }
}
        

   


