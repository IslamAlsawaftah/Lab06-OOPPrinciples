using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal // parent class
    {
        // properities
        public virtual string Name { get; set; } 
        public virtual int LivedYears { get; set; }

        // parent class methods which are going to be inherited, i used these methods among sun classes which result in polymorphism principle
        public virtual void Eat()
        {
            Console.Write("i eat a ");
        }
        public virtual void Sleep()
        {
            Console.Write("i sleep ");
        }
        public void Sound()
        {
            Console.Write("my sound is ");
        }
        public void Tail()
        {
            Console.Write("im an animal,");
        }
    }
}
