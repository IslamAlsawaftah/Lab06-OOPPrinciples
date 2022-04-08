using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{

    public class Eagle : Preybirds // class eagle child inhert form preybirds parent
    {
        public override void EyeColor()
        {
            Console.WriteLine("eagle have sharpen eyes");
        }
    }
}
