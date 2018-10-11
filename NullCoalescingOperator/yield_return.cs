using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class yield_return
    {
        public static void Demo()
        {
            //var result = from i in Enumerable.Range(1, 98)
            //             where  i % 2 == 0
            //             select i; 

            var results = new FibonacciSequence();

            foreach (var result in results)
            {
                Console.Write($"{result} ");
            }
        }

        public static IEnumerable<int> GetFibonacciSequence()
        {
            int current = 1;
            int previous = 1;

            while (current <= 100)
            {
                yield return current;
                int old = current;
                current = current + previous;
                previous = old;
            }
        }
    }
}
