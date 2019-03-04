using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[5];
            int sum = 0;
            Console.WriteLine("Please enter 5 values");
            for(int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a = 0; a < 5; a++)
            { 

                sum += inputArr[a];
            }
            Console.WriteLine(sum);

            //foreach (int item in inputArr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
