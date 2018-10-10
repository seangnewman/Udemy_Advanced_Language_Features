using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Soft_Typecast
    {
        public static void Demo()
        {
            object[] array = new object[6]
            {
                DateTime.Now,
                true,
                "hello",
                123,
                123.4,
                'x'
            };

            
            int index = 0;

            foreach (object o in array)
            {
                int? i = (o as int?);
               Console.WriteLine("{0}: {1}", index++,   i ?? -1);

            }
        }
    }
}
