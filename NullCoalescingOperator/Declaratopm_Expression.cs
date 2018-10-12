using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Declaratopm_Expression
    {
        public static void Demo()
        {
            int input;

            input = Console.Read();

            while((input = Console.Read()) != 10) // char 10 is the linefeed 
            {
                Console.Write((char)input);
                input = Console.Read();
            }
        }
    }
}
