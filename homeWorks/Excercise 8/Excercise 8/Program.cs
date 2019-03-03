using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1,2 or 3");
            int num;
            bool input = Int32.TryParse(Console.ReadLine(), out num);
            if (input = true && num <= 3)
            {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("You got a new car");
                            break;
                        case 2:
                            Console.WriteLine("You got a new plane");
                            break;
                        case 3:
                            Console.WriteLine("You got a new bike");
                            break;
                    };
               

            }
            else
            {
                Console.WriteLine("You did something wrong!! Try again");
            };
            Console.ReadLine();
        }
    }
}
