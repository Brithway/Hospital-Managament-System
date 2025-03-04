using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    internal class AddPatient : Person
    {
        // Create an instance of the `data` class to manage patient-related operations.
        data d = new data();

        // Auto-implemented property to store the patient's unique number.
        public string PatientNumber { get; set; }

        // Constructor to initialize a new patient with details.
        // Accepts parameters for name, address, county, age, phone, email, and patient number.
        public AddPatient(string ne, string ad, string cy, int ag, string ph, string em, string pn)
            :base(ne, ad, cy, ag, ph, em) // Calls the base class constructor to initialize inherited properties.
        {
            // Set the patient number to the provided value.
            PatientNumber = pn;
        }

        // Method to add a new patient record.
        public void AddNewPatient()
        {
            // Add a new patient to the `data` instance with all the relevant details.
            d.AddPatient(Name, Address, County, Age, Phone, Email, PatientNumber);
        }
    }

}
