using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
    {
    // child reptile inherit from parent animal and i legs num interface    
     public class Reptile : Animal, ILegsNum
    {
        public new string Sound()
        {
            return "we are reptile,";
        }
        public override string Eat()
        {
            return "we eat meat";
        }
        // <interface>
        public string LegsNum()
        {
            return "I have four legs";
        }
        // child lizzard imhrit from parent reptile
        public class Lizard : Reptile
        {
            public new string Sound()
            {
               return "im a lizard, my sound is hissing,";
            }
            public new string Tail()
            {
                return "i have tail";
            }
        }
    }
}
