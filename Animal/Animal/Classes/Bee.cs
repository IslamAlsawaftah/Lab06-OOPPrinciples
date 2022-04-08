using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    public abstract class Bee : FlyingBugs
    {
        public abstract string Weghit();
        public abstract string Name  //create abstract property Name
        {
            get; set;
        }
        public abstract int Id       //create abstract property Id

        {
            get;
            set;
        }
    }
}
