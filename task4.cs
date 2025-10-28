using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task4
    {
        public static void Main(string[] args)
        {
            decimal a = -5 + 8 * 6;
            decimal b = (55m + 9m) % 9m;
            decimal c = 20m + -3m * 5m / 8m;
            decimal d = 5m + 15m / 3m * 2m - 8m % 3m;

            Console.WriteLine("The result of a is " + a);
            Console.WriteLine("The result of b is " + b);
            Console.WriteLine("The result of c is " + c);
            Console.WriteLine("The result of d is " + d);
            Console.ReadLine();
        }

    }
}
