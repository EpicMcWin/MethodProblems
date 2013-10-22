using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P195_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price of car: ");
            string carPrice = Console.ReadLine();
            double price  = Convert.ToInt32(carPrice);
            double commision;

            if (price <= 15000)
                commision = price * .05;

            else if (price > 15000 && price <= 24000)          
                commision = price * .07;

            else if (price > 24000)        
                commision = price * .10;    
    
            else
                commision = 0;
            

            Console.WriteLine("The commision is {0}.", commision.ToString("C"));
        }
    }
}
