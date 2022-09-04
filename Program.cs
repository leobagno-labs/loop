// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
            Console.ReadLine();
        }
    }
}
