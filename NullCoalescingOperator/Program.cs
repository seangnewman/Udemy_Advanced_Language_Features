using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Program
    {
        static void Main(string[] args)
        {


            var testing = NullCoalescingOperator.Demo("Harvey Mudd");
            var intTest = NullCoalescingOperator.Demo(7);
            Console.WriteLine(testing);
            Console.WriteLine(8);
             
        }


    }
}
