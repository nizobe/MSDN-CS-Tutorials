using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Taken from
//https://msdn.microsoft.com/en-us/library/aa288463(v=vs.71).aspx

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"{args.Length} number of arguments were entered.");
            Console.WriteLine("Those arguments are as follows:");
            foreach (string str in args)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();

            return 0;
        }
    }
}
