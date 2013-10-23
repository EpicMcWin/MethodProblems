using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P244_3
{
    class Monogram
    {
        public static void Main()
        {
            DisplayMonogram("T", "J", "B");
            DisplayMonogram("J", "E", "L");
            Console.ReadKey();
        }

        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2} **", first, middle, last);
            
        }
        
    }
}
