using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    // class child insects inherit from parent animal and i fly interface
    public class Insects : Animal,IFly
    {
        public override string Eat()
        {
            return "im bee i eat honey,";
        }
        // <interface>
        public string Fly()
        {
            return "i can fly";
        }
        // child flyingbug inherit from insects
        public class FlyingBugs : Insects
        {

            public new string Sound()
            {
                base.Sound();
                return "buzzing";
            }

            public abstract class Bee
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
            // class flying bee inherit from parent bee
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

    }
}
