using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class task8
    {
        public static void Main(string[] args)
        {
            int f = 25;
            int s = 39;

            if (f == s)
                Console.WriteLine($"{f}=={s}");
            if (f < s)
                Console.WriteLine($"{f}<{s}");
            if (f > s)
                Console.WriteLine($"{f}>{s}");
            if (f != s)
                Console.WriteLine($"{f}!={s}");
            if (f <= s)
                Console.WriteLine($"{f}<={s}");
            if (f >= s)
                Console.WriteLine($"{f}>={s}");
            Console.ReadLine();
        }

    }
}
