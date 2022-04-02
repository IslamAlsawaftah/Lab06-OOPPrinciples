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
        public override void Eat()
        {
            Console.WriteLine("im bee i eat honey,");
        }
        // <interface>
        public void Fly()
        {
            Console.WriteLine("i can fly");
        }
        // child flyingbug inherit from insects
        public class FlyingBugs : Insects
        {

            public new void Sound()
            {
                base.Sound();
                Console.WriteLine("buzzing");
            }

            public abstract class Bee
            {
                public abstract void Weghit();
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
                private string name;

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
                public override void Weghit()
                {
                    Console.WriteLine("bee weghit is very weghit");
                }
            }

        }

    }
}
