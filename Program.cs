using Generics.Entities;
using System;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            PrintService<int> printService = new PrintService<int>();

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());  
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine();
            Console.WriteLine("First: " + printService.First());
        }
    }
}