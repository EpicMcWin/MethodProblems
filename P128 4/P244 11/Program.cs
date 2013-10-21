using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P244_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            Console.WriteLine("After InputMethod first is {0}", first);
            Console.WriteLine("and second is {0}", second);
        }
        public static void InputMethod(out int one, out int two)
        {
            string s1, s2;
            Console.Write("enter first integer ");
            s1 = Console.ReadLine();
            Console.Write("Enter second integer ");
            s2 = Console.ReadLine();
            one = Convert.ToInt32(s1);
        }
    }
}
