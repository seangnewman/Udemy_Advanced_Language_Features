using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class ObjectInitializers
    {
        public int X { get; set; }
        public int Y { get; set; }

        public struct Point
        {
            public int X;
            public int Y;
        }

        public override string ToString()
        {
            return string.Format($"{X} : {Y}");
        }

        public static void Demo()
        {
            var p1 = new Point { X=6, Y = 9 };

            // Anonymous Types
            var p2 = new { X = 12, Y = 18 };

            // List initialization
            var points1 = new List<Point>
            {
                new Point { X=6,  Y = 0 },
                new Point { X=9,  Y = 3 },
                new Point { X=12, Y = 6 },
                new Point { X=15, Y = 9 }
            };

            // Specifying capacity
            var points2 = new List<Point> (200)
            {
                new Point { X=6,  Y = 0 },
                new Point { X=9,  Y = 3 },
                new Point { X=12, Y = 6 },
                new Point { X=15, Y = 9 }
            };

            // Dictionary
            var colors1 = new Dictionary<int, string>
            {
                {0x00000FF, "Blue" },
                {0x000FF00, "Green" },
                {0x0FF0000, "Blue" }
            };

            // using indexers
            // Dictionary
            var colors2 = new Dictionary<int, string>
            {
                [0x00000FF] = "Blue",
                [0x000FF00] = "Green",
                [0x0FF0000] = "Blue"
            };

        }
    }

   
}
