using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
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
