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
            string[] names = new string[1];
            bool isTrue = true;
            Console.WriteLine("Please enter the name");
            string input = Console.ReadLine();
            int lastItem = names.Length - 1;
            names[lastItem] = input;
            while (isTrue)
            {
                
                Console.WriteLine("Enter Y if you want to add another name or N if you want to exit");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "Y")
                {
                    Console.WriteLine("Please enter the name");
                    string secondInput = Console.ReadLine();
                    Array.Resize(ref names, 1);
                    lastItem = names.Length - 1;
                    names[lastItem] = secondInput;
                }
                else
                {
                    break;
                }
                

            }
            
        }
    }
}
