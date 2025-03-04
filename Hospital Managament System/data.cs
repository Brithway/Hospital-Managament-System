using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Hospital_Managament_System
{
    internal class data : DAO
    {
        SqlDataAdapter da;
        DataTable dt;

        public void AddDoctor(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, decimal py)
        {
            // Create a SQL command object to execute a stored procedure.
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspNewDoctor"; // Specify the stored procedure name.
            cmd.CommandType = System.Data.CommandType.StoredProcedure; // Indicate it's a stored procedure.

            // Add parameters to the SQL command with corresponding values.
            cmd.Parameters.AddWithValue("@ne", ne);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ag", ag);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@se", se);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@py", py);

            // Execute the command to insert the doctor into the database.
            cmd.ExecuteNonQuery();

            // Close the database connection after the operation.
            CloseCon();
        }
        
        public void AddNurse(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string hr, string ge)
        {
            
            SqlCommand cmd= OpenCon().CreateCommand();
            cmd.CommandText = "uspNewNurse";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ne", ne);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ag", ag);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@se", se);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@hr", hr);
            cmd.Parameters.AddWithValue("@ge", ge);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddPatient(string ne, string ad, string cy, int ag, string ph, string em, string pn)
        {
            // Create a SQL command object to execute a stored procedure.
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspNewPatient"; // Specify the stored procedure name.
            cmd.CommandType = System.Data.CommandType.StoredProcedure; // Indicate it's a stored procedure.

            // Add parameters to the SQL command with corresponding values.
            cmd.Parameters.AddWithValue("@ne", ne);
            cmd.Parameters.AddWithValue("@ad", ad); 
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ag", ag);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@pn", pn);

            // Execute the command to insert the patient into the database.
            cmd.ExecuteNonQuery();

            // Close the database connection after the operation.
            CloseCon();
        }

        public void AddReceptionist(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string st)
        {

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspNewReceptionist"; // Stored procedure to add a receptionist.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // Adding parameters to the stored procedure.
            cmd.Parameters.AddWithValue("@ne", ne);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ag", ag);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@se", se);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@st", st);

            cmd.ExecuteNonQuery(); // Executes the stored procedure.

            CloseCon(); // Closes the database connection.

        }

        public void AddTechnician(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string ct)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspNewTechnician"; // Stored procedure to add a technician.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // Adding parameters to the stored procedure.
            cmd.Parameters.AddWithValue("@ne", ne);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ag", ag);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@se", se);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@ct", ct);

            cmd.ExecuteNonQuery(); // Executes the stored procedure.

            CloseCon(); // Closes the database connection.
        }

        public DataTable User()
        {
            da = new SqlDataAdapter(); // Initializes a data adapter.
            dt = new DataTable(); // Initializes a data table.

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspUser"; // Stored procedure to fetch user data.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd; // Links the command to the data adapter.
            da.Fill(dt); // Fills the data table with the results.

            return dt; // Returns the data table containing user information.
        }

        public DataTable AllDoctors()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllDoctors"; // Stored procedure to fetch all doctors.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable AllNurses()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllNurses"; // Stored procedure to fetch all Nurses.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable AllPatients()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllPatients"; // Stored procedure to fetch all Patient.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable AllReceptionist()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllReceptionist"; // Stored procedure to fetch all Receptionist.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable AllTechnician()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllTechnician"; // Stored procedure to fetch all Technician.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable MaleNurses()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspMaleNurses"; // Stored procedure to fetch all Male Nurses.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable PatientsAbove25()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspPatientsAbove25"; // Stored procedure to fetch all Patients Above 25.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable TechnicianByDepartment()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspTechnicianByDepartment"; // Stored procedure to fetch all Technician By Department.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }

        public DataTable GetReceptionist()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspGetReceptionist"; // Stored procedure to fetch all Get Receptionist.
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt); // Fills the data table with the query result.

            return dt; // Returns all doctor records.
        }
    }
}
