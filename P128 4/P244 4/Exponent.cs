using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P244_4
{
    class Exponent
    {
        public static void Main()
        {
            Console.Write("Enter integer: ");
            string input = Console.ReadLine();
            int integer = Convert.ToInt32(input);
            Square(integer);
            Cube(integer);
            Console.ReadKey();
        }

        public static void Square(int num)
        {
            num = (int)Math.Pow(num, 2);
            Console.WriteLine(num);
        }

        public static void Cube(int num)
        {
            num = (int)Math.Pow(num, 3);
            Console.WriteLine(num);
        }
    }
}
