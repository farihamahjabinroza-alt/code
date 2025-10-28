using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter Second number: ");

            int d = int.Parse(Console.ReadLine());

            int divide = c / d;

            Console.WriteLine($"The division of {c} and {d} is {divide}");
            Console.ReadLine();
        }

    }
}
