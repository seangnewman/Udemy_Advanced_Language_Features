using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class LINQ_Queries
    {

        public static void Demo()
        {
            string[] names =
            {
            "Tony", "Bruce", "Thor", "Captain", "Vision",
            "Natasha", "Barton", "Pieter", "Hill"

            };

            var results = new List<string>();

            foreach (string name in names)
            {
                if(name.StartsWith("B"))
                {
                    results.Add(name.ToUpper());
                }
            }
        }
        
    }
}




}
}
