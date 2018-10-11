using System;
using System.Linq;

namespace AdvancedFeatures
{
    class LINQ
    {

        public static void Demo()
        {
            string[] names =
            {
                "Billy", "Bob", "Brad", "David", "Duncan", "Everett", "Hannah", "Mark",
                "Michael", "Theo", "Tom", "Victor", "Wendy"
            };



            var results = (from name in names
                          where name.StartsWith("B")
                          select name.ToUpper())
                          .Any() ? "At least 1 name starts with B " : "No names start with B";


            Console.WriteLine(string.Join(" ", results));


            var _groups = from name in names
                          group name by name[0] into groups
                          select groups;

            foreach (var group in _groups)
            {
                Console.WriteLine($"{group.Key} : {string.Join(" ",group)}");
                 
            }

        }
    }
}
