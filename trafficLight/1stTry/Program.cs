using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stTry
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("    Stop     ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("  Get Ready  ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("    Go       ");

         

            Console.ReadLine();
        }
    }
}
