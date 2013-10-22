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
            string myFirst;
            string myMiddle;
            string myLast;

            string friendFirst;
            string friendMiddle;
            string friendLast;

            DisplayMonogram("T", "J", "B");
        }

        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2} **", first, middle, last);
        }
    }
}
