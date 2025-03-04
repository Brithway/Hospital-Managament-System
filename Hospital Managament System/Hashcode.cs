using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managament_System
{
    internal class Hashcode
    {
        // Method to hash the provided data using SHA1.
        // This method takes a string 'data' and returns a SHA1 hash as a string.
        public string Passhash(string data)
        {
            // Create a new SHA1 instance to compute the hash.
            SHA1 sha = SHA1.Create();

            // Convert the input string data into a byte array using default encoding (system's default encoding).
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));

            // Use a StringBuilder to efficiently build the hash string.
            StringBuilder sb = new StringBuilder();

            // Iterate through the byte array containing the hash data.
            for (int i = 0; i < hashdata.Length; i++)
            {
                // Append each byte of the hash to the StringBuilder.
                // Each byte is implicitly converted to its integer representation.
                sb.Append(hashdata[i]);
            }

            // Return the hash as a string.
            return sb.ToString();
        }
    }
}
