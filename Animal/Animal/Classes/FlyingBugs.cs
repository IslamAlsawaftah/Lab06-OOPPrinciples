using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    public class FlyingBugs : Insects
    {

        public new string Sound()
        {
            base.Sound();
            return "buzzing";
        }
    }
    }
