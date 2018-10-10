using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Useful_String_Methods
    {
        public static string GetFullName_IsNullOrEmpty(string firstName, string lastName)
        {
            // IsNullOrEmpty, IsNullOrWhiteSpace, String.Equals()
            string result = null;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                return lastName;
            }
            else
            {
                return $"{firstName} {lastName}";
            }

            result = "Connor Newman";

            Console.WriteLine("Is this Connor? {0}", string.Equals(result, "Connor Newman",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}
