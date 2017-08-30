using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//taken from
//https://msdn.microsoft.com/en-us/library/aa288457(v=vs.71).aspx

namespace CLI_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of command line parameters: {0}", args.Length);

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }

            Console.WriteLine("END OF PARAMETERS");

            Console.ReadKey();
        }
    }
}
