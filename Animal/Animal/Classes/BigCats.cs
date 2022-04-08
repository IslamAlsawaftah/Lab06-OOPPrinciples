using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    public class BigCats : Mammals,ILegsNum // child class derived from parent mammals
    {
        private string name;

        public override string Name   // Declare abstract Name property:
        {
            get

            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public BigCats(string Name)
        {
            this.name = Name;
        }
        public override string Sleep()
        {
            return "i sleep 20 hour,";
        }
        public new string Tail()
        {
            return "i have tail,";
        }
        public string LegsNum()
        {
            return "I have four legs";
        }
    }
}
