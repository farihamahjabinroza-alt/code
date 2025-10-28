using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Strings: ");
            String s = Console.ReadLine();

            Console.Write("Reverse Strings: ");

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
