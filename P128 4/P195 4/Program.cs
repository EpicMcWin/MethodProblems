using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P195_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCode = new int[6]{262, 414, 608, 715, 815, 920};
            double[] rate = new double[6]{0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
            double price;
            string inputCode;
            string inputMinutes;

            Console.WriteLine("Enter area code.");
            inputCode = Console.ReadLine();
            Console.WriteLine("Enter length of call in minutes.");
            inputMinutes = Console.ReadLine();

            for (int i = 0; i < areaCode.Length; i++)
            {
                if (inputCode == areaCode[i].ToString())
                {
                    price = rate[i] * Convert.ToInt32(inputMinutes);
                    Console.WriteLine("The cost of your call is {0}.", price.ToString("C"));
                    break;
                }

                else if (i == 5)
                {
                    Console.WriteLine("We do not cover your area.");
                }
                
            }
            
        }
    }
}
