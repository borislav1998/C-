using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int sumEven = 0;
            for (int i = 2; i <= input; i+=2)
            {
                    Console.Write(i);
                    if (i != input)
                    {
                        Console.Write(", ");
                    }
                sumEven = sumEven + i;

            }
            Console.WriteLine(sumEven);

            int secondInput = Convert.ToInt32(Console.ReadLine());
            for (int i = secondInput; i > 0; i--)
            {
                if (i % 2 != 0) {
                    Console.Write(i);
                    if (i != 1)
                    {
                        Console.Write(", ");
                    }
                }
            }

            //do
            //{
            //    Console.Write(secondInput);
            //    secondInput--;
            //    if(secondInput != 0)
            //    {
            //        Console.Write(", ");
            //    }
            //} while (secondInput > 0);


            Console.ReadLine();

        }

    }
}
