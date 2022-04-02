using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Mammals : Animal // child class derived from parent animal
    {
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine(" 4 hours per day,");
        }
        public new void Tail()
        {
            Console.WriteLine("im a mummal i have tail");
        }
        public class BigCats : Mammals // child class derived from parent mammals
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
            public override void Sleep()
            {
                Console.Write("i sleep 20 hour,");
            }
            public  void Tail()
            {
                Console.WriteLine("i have tail,");
            }
            public void LegsNumFour()
            {
                Console.WriteLine("I have four legs");
            }
        }
    }
}
