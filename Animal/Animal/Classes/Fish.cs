using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    // class fish child inherit from animal parent class
    public class Fish : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("we are fishes we eat meat");
        }
        public new void Tail()
        {
            Console.WriteLine("we have tail");
        }
        public abstract class Whale // abstraction
        {
            public abstract void Color();
        }
        public class BlueWhale : Whale // class child bluewhale inherit from parent whale  
        {
            public override void Color()
            {
                Console.WriteLine("im whale my color is blue");
            }
  
        }

    }
}
