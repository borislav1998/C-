using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++) {
                for (int a = 1; a <= 100; a++) { 
                if (i % 3 != 0 && i % 7 != 0)
                {
                    
                        Console.WriteLine(a + ".Number " + i);
                    
                }
            } }
            Console.ReadLine();
        }
    }
}
