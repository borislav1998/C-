using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operant:");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int result;
            switch (character)
            {
                case '+':
                    result = firstNum + secondNum;
                    Console.WriteLine("The result is: " + result);
                    break;
                case '-':
                    result = firstNum - secondNum;
                    Console.WriteLine("The result is: " + result);
                    break;
                case '*':
                    result = firstNum * secondNum;
                    Console.WriteLine("The result is: " + result);
                    break;
                case '/':
                    result = firstNum / secondNum;
                    Console.WriteLine("The result is: " + result);
                    break;
                default:
                    Console.WriteLine("You entered wrong operant");
                    break;

            }
            Console.ReadLine();
        }
    }
}
