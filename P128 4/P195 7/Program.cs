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
            double commission;

            if (price <= 15000)
                commission = price * .05;

            else if (price > 15000 && price <= 24000)          
                commission = price * .07;

            else if (price > 24000)        
                commission = price * .10;    
    
            else
                commission = 0;
            

            Console.WriteLine("The commision is {0}.", commission.ToString("C"));
        }
    }
}
