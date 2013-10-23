using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P244_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of integers");
            string lengthInput = Console.ReadLine();
            int length = Convert.ToInt32(lengthInput);
            Sum(length);
            Console.ReadKey();
        }

        public static void Sum(int length)
        {
            int[] sum = new int[length];
            int result = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write("Input integer #{0}: ", i + 1);
                string input = Console.ReadLine();
                sum[i] = Convert.ToInt32(input);
                result += sum[i];
            }

            Console.WriteLine("Your sum is {0}", result);

        }
    }
}
