using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class Animal // parent class
    {
        // properities
        public virtual string Name { get; set; } 
        public virtual int LivedYears { get; set; }

        // parent class methods which are going to be inherited, i used these methods among sun classes which result in polymorphism principle
        public virtual string Eat()
        {
            return "i eat a ";
        }
        public virtual string Sleep()
        {
            return "i sleep ";
        }
        public string Sound()
        {
            return "my sound is ";
        }
        public string Tail()
        {
            return "im an animal,";
        }
    }
}
