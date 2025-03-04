using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Managament_System
{
    // This class represents a Staff member, which extends the Person class by adding staff-specific attributes.
    internal class Staff : Person
    {
        // Auto-implemented property for the staff's unique identifier or code.
        public string StaffCode { get; set; }

        // Auto-implemented property for the staff's department.
        public string Department {  get; set; }

        // Constructor to initialize a new Staff object with both person and staff-specific details.
        public Staff(string ne, string ad, string cy, int ag, string ph, string em, string se, string dt)
            :base(ne, ad, cy, ag, ph, em) // Calls the base class (Person) constructor to initialize shared attributes.
        {
            // Assign the staff-specific details to the corresponding properties.
            StaffCode = se;
            Department = dt;
        }
    }
}
