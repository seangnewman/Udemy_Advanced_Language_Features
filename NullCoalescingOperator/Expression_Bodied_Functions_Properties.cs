using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Expression_Bodied_Functions_Properties
    {
        public class Person_With_ToString
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public bool HasFirstName => !string.IsNullOrWhiteSpace(FirstName);

            public override string ToString() => string.Format("{0} {1}", FirstName, LastName);
        }

        public static void Demo()
        {
            var person = new Person_With_ToString();
            person.FirstName = "Cody";
            person.LastName = "Newman";
            if(person.HasFirstName)
            {
                Console.WriteLine(person);
            }
            
        }
    }
}
