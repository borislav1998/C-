using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount in MKDenars");
            double denars = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter USD,EUR or GBP");
            string currency = Console.ReadLine();
            double usd = 0.019;
            double eur = 0.016;
            double gbp = 0.014;
            double result;
            switch (currency)
            {
                case "USD":
                    result = denars * usd;
                    Console.WriteLine("The amount in USD is: " + result);
                    break;
                case "EUR":
                    result = denars * eur;
                    Console.WriteLine("The amount in EUR is: " + result);
                    break; 
                case "GBP":
                    result = denars * gbp;
                    Console.WriteLine("The amount in GBP is: " + result);
                    break;
                default:
                    Console.WriteLine("You entered wrong currency");
                    break;
            }
            Console.ReadLine();
        }
    }
}
