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
        public override string Eat()
        {
            return "we are fishes we eat meat";
        }
        public new string Tail()
        {
            return "we have tail";
        }
        public abstract class Whale // abstraction
        {
            public abstract string Color();
        }
        public class BlueWhale : Whale // class child bluewhale inherit from parent whale  
        {
            public override string Color()
            {
               return "im whale my color is blue";
            }
  
        }

    }
}
