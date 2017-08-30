using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"{args.Length} number of arguments were entered.");
            Console.WriteLine("Those arguments are as follows:");
            foreach (string str in args)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
