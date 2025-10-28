using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second number: ");

            int b = int.Parse(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.ReadLine();
        }

    }
}
