using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, i;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                i = number % 10;
                sum = sum + i;
                number = number / 10;
            }

            Console.WriteLine(sum = sum);
            Console.ReadLine();


        }
    }
}