using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P195_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ZipCodes = new string[10];
            ZipCodes[0] = "12345";
            ZipCodes[1] = "22345";
            ZipCodes[2] = "32345";
            ZipCodes[3] = "42345";
            ZipCodes[4] = "52345";
            ZipCodes[5] = "62345";
            ZipCodes[6] = "72345";
            ZipCodes[7] = "82345";
            ZipCodes[8] = "92345";
            ZipCodes[9] = "02345";

            Console.Write("Enter your zip code to see if we deliver to you : ");
            string input = Console.ReadLine();
            for (int i = 0; i < ZipCodes.Length; i++)
            {
                if (input == ZipCodes[i])
                {
                    Console.WriteLine("We deliver to you!");
                    break;
                }
                else if (i == ZipCodes.Length - 1)
                {
                    Console.WriteLine("Sorry!  We don't deliver to your area!");
                }          
            }   
        }
    }
}
