using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excericse_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            if (firstInt > secondInt)
            {
                Console.WriteLine("First number is bigger");
                if (firstInt % 2 == 0)
                {
                    Console.WriteLine("The first number is even.");
                }
                else
                {
                    Console.WriteLine("The first number is odd.");
                }

            }
            else if (secondInt > firstInt)
            {
                Console.WriteLine("Second number is bigger");
                if (firstInt % 2 == 0)
                {
                    Console.WriteLine("The second number is even.");
                }
                else
                {
                    Console.WriteLine("The second number is odd.");
                }
            }

            else if (firstInt == secondInt)
            {
                Console.WriteLine("Numbers are equal.");
                if (firstInt % 2 == 0 && secondInt % 2 == 0)
                {
                    Console.WriteLine("The numbers are even.");
                }
                else
                {
                    Console.WriteLine("The numbers are odd.");
                }
            }
            else
            {
                Console.WriteLine("Something happend!! Please try again.");
            }
            Console.ReadLine();
          
        }
    }
}
