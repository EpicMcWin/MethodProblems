using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int price;
            Console.WriteLine("(P)ine, (O)ak, (M)ahogany?");
            string input = Console.ReadLine();
            if (input == "P")
            {
                price = 100;
            }
            else if (input == "O")
            {
                price = 225;
            }
            else if (input == "M")
            {
                price = 310;
            }
            else
            {
                price = 0;
            }
            Console.WriteLine(price.ToString("C"));
            Console.ReadKey();
        }
    }
}
