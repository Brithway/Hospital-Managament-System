 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    internal class AddTechnician : Staff
    {
        // Instance of the data class for handling database operations.
        data d = new data();

        // Property to store the technician's certification details.
        public string Certification {  get; set; }

        // Constructor to initialize an AddTechnician object with all necessary details.
        public AddTechnician(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string ct)
            :base(ne, ad, cy, ag, ph, em, se, dt) // Calls the constructor of the Staff base class.
        { 
            Certification = ct; // Initializes the Certification property specific to technicians.
        }

        // Method to add a new technician to the database.
        public void AddNewTechnician()
        {
            // Calls the AddTechnician method from the data class to save technician details.
            d.AddTechnician(Name, Address, County, Age, Phone, Email, StaffCode, Department, Certification);
        }
    }
}
