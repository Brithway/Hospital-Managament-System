 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    
    internal class AddDoctor : Staff
    {
        // Create an instance of the `data` class for managing doctor-related data.
        data d = new data();

        // Create an instance of the `data` class for managing doctor-related data.
        public decimal Pay {  get; set; }

        public AddDoctor(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt, decimal py)
            :base(ne, ad, cy, ag, ph, em, se, dt) // Calls the base class constructor to initialize inherited properties.
        {
            // Assign the doctor's pay to the provided value.
            Pay = py;
        }

        // Method to add a new doctor to the data store.
        public void AddNewDoctor()
        {
            // Use the `data` instance to add the doctor with all their details (including pay).
            d.AddDoctor(Name, Address, County, Age, Phone, Email, StaffCode, Department, Pay);
        }
    }
}
