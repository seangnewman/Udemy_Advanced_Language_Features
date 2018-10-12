using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Auto_Property
    {
        public class Immutable_Person
        {
            public string Name { get; } = "Sean Newman";
        }

        public class Person
        {
            public string Name { get; set; } = "Sean Newman";
        }

        public class Complex_Person
        {
            public string Name { get; } = System.Security.Principal.WindowsPrincipal.Current.Identity.Name;
        }

        public static void Demo()
        {
            Console.WriteLine(new Person().Name);

        }
    }
}
