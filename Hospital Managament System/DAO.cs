using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Hospital_Managament_System
{
    internal class DAO // Data Access Object
    {
        // Declare a SqlConnection object to interact with the database.
        SqlConnection con;

        // Constructor to initialize the connection object.
        // Retrieves the connection string from the configuration settings.
        public DAO()
        {
            // Get the connection string from the configuration file (app.config).
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString);
        }

        // Method to open the database connection if it's not already open or broken.   
        public SqlConnection OpenCon()
        {
            // Check if the connection state is Broken or Closed.
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                // Open the connection if it's either broken or closed.
                con.Open();
            }
            // Return the open connection.
            return con;
        }

        // Method to close the database connection if it's open.
        public void CloseCon()
        {
            // Check if the connection object is not null.
            if (con != null)
            {
                // Check if the connection is currently open.
                if (con.State == ConnectionState.Open)
                {
                    // Close the connection if it's open.
                    con.Close();
                }
            }
        }
    }
}
