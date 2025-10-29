using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project
{
    internal class task10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            bool result = (a > 0 && a < 1) && (b > 0 && b < 1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

