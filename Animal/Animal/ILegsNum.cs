using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal interface ILegsNum
    {
        public void LegsNumFour()
        {
            Console.WriteLine("I have four legs");
        }
        public void LegsNumTWo()
        {
            Console.WriteLine("I have two legs");
        }
    }
}
