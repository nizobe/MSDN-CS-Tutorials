using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//take from:
//https://msdn.microsoft.com/en-us/library/aa288470(v=vs.71).aspx

namespace Properties
{
    class Person
    {
        private string myName = "N/A";
        private int myAge = 0;

        public string Name
        {
            get
            {
                return myName;
            }

            set
            {
                myName = value;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
