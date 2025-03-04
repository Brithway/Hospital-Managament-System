using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // for SQL Connection

namespace Hospital_Managament_System
{
    public partial class Register : Form
    {
        // Constructor for the Register form. Initializes the UI components.
        public Register()
        {
            InitializeComponent();
        }

        // Create instances of helper classes for hashing passwords and database operations.
        Hashcode hs = new Hashcode();
        DAO dao = new DAO();

        // Event handler for the Register button click event.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Retrieve the full name, username, and hashed password from the input fields.
            string FullName = txtFn.Text;
            string UserName = txtUn.Text;
            string Password = hs.Passhash(txtPd.Text);

            // Set up the SQL command to interact with the database using a stored procedure.
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspRegister"; // Name of the stored procedure for user registration.
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parameters to the command for the stored procedure.
            cmd.Parameters.AddWithValue("@Fn", FullName); // Full name parameter.
            cmd.Parameters.AddWithValue("@Un", UserName); // Username parameter.
            cmd.Parameters.AddWithValue("@Pd", Password); // Password parameter (hashed).

            // Execute the SQL command to insert the new user into the database.
            cmd.ExecuteNonQuery();

            // Close the database connection after completing the operation.
            dao.CloseCon();

            // Clear the input fields to reset the form.
            txtFn.Clear();
            txtUn.Clear();
            txtPd.Clear();

            // Close the registration form after successful registration.
            this.Close();

        }
       
    }
}
