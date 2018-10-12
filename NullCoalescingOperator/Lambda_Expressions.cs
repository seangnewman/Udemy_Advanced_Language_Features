using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Lambda_Expressions
    {
        public delegate int MathOperationDelegate(int number);

        private static int Multiply(int value)
        {
            return value * value;
        }

        public static void Demo()
        {
            int value = 5;
            //int result;

            MathOperationDelegate operation1 = new MathOperationDelegate(Multiply);


            //result = operation1(value);
            //Func<int, int> operation2 = Multiply;
           // var result = operation2(value);

            Func<int, int> operation3 = x => x * x;
            var result = operation3(value);


            Console.WriteLine(result);
        }
    }
}
