using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    // class Birds inherit from Animal as parent class. ILegsNum,IFly  as interfaces
    public class Birds : Animal,ILegsNum,IFly 
    {
        public override void Eat()
        {
            Console.WriteLine("we are birds we eat meat and vegetables");
        }
        // <interface>
        public void LegsNumTWo()
        {
            Console.WriteLine("I have two legs");
        }
        // <interface>
        public void Fly()
        {
            Console.WriteLine("i can fly");
        }
        public abstract class Preybirds // abstraction
        {
            public abstract void EyeColor();


            public  class Eagle : Preybirds // class eagle child inhert form preybirds parent
            {
                public override void EyeColor()
                {
                    Console.WriteLine("eagle have sharpen eyes");
                }
            }
        

        }
    }
}
