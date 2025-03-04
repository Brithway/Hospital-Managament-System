 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    internal class AddNurse : Staff
    {
        // Create an instance of the `data` class to handle nurse-related data operations.
        data d = new data();

        // Auto-implemented property to store the nurse's working hours.
        public string Hours { get; set; }

        // Property to store the gender of a person.
        public string Gender { get; set; }

        public AddNurse(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, string hr, string ge)
            :base(ne, ad, cy, ag, ph, em, se, dt) // Calls the base class constructor to initialize inherited properties.
        {
            // Assign the nurse's working hours and Gender to the provided value.
            Hours = hr;
            Gender = ge;
        }

        // Method to add a new nurse to the data store.
        public void AddNewNurse()
        {
            // Use the `data` class instance to add the nurse with all their details (including working hours and Gender).
            d.AddNurse(Name, Address, County, Age, Phone, Email, StaffCode, Department, Hours, Gender);
        }
    }
}
