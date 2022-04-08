using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    public class Flyingbee : Bee
    {
        private string name; // encapsulation

        private int id;
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
        public override int Id       // Declare abstract Id property:
        {
            get
            {
                return id;
            }
            set
            {
                id = value;

            }
        }
        public override string Weghit()
        {
            return "bee weghit is very weghit";
        }
    }
}
