using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Managament_System
{
    internal class AddReceptionist : Staff
    {
        // Instance of the data class for database operations.
        data d = new data();

        // Property to store the shift of the receptionist.
        public string Shift {  get; set; }

        // Constructor to initialize the AddReceptionist object with necessary details.
        public AddReceptionist(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string st)
            : base(ne, ad, cy, ag, ph, em, se, dt) // Calls the constructor of the Staff base class.
        {
            // Initializes the Shift property specific to receptionists.
            Shift = st;
        }

        // Method to add a new receptionist to the database.
        public void AddNewReceptionist()
        {
            // Calls the AddReceptionist method from the data class to save receptionist details.
            d.AddReceptionist(Name, Address, County, Age, Phone, Email, StaffCode, Department, Shift);
        }
    }
}
