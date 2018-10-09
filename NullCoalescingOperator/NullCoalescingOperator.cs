using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class NullCoalescingOperator
    {
        public static string Demo(string value)
        {
            return value ?? string.Empty;
        }

        public static int Demo(int? value)
        {
            int? temp = null;
            return temp ?? default(int);
        }
    }
}
