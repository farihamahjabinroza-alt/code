using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second Number: ");
            decimal b = decimal.Parse(Console.ReadLine());

            decimal sum = a + b;
            decimal minus = a - b;
            decimal devision = a / b;
            decimal multiplication = a * b;
            decimal Remainder = a % b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The minus of {a} and {b} is {minus}");
            Console.WriteLine($"The devision of {a} and {b} is {devision}");
            Console.WriteLine($"The multiplication of {a} and {b} is {multiplication}");
            Console.WriteLine($"The remainder of {a} and {b} is {Remainder}");
        }
    }
}
