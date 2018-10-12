using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Null_Conditional_Operator
    {

        private static string Truncate(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length));
        }

        public static void Demo()
        {
            string name = Truncate(null, 11);
            Console.WriteLine(name?? "null");
        }
    }
}
