using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    // This class defines a Person with common attributes such as Name, Address, etc
    internal class Person
    {
        // Auto-implemented property for the person's name.
        public string Name { get; set; }

        // Auto-implemented property for the person's address.
        public string Address { get; set; }

        // Auto-implemented property for the person's county or city.
        public string County { get; set; }

        // Auto-implemented property for the person's age.
        public int Age { get; set; }

        // Auto-implemented property for the person's phone number.
        public string Phone { get; set; }

        // Auto-implemented property for the person's email address.
        public string Email { get; set; }


        // Constructor to initialize a new Person object with the provided details.
        public Person(string ne, string ad, string cy, int ag, string ph, string em)
        {
            // Assign the provided values to the corresponding properties.
            Name = ne;
            Address = ad;
            County = cy;
            Age = ag;
            Phone = ph;
            Email = em;
        }


    }
}
