using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class lab1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("The person is Minor ");
            else if (age < 60)
                Console.WriteLine("The person is Adult ");
            else
                Console.WriteLine("The person is senior");
                }
    }
}
