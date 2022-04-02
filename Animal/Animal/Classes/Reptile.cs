﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    // child reptile inherit from parent animal and i legs num interface    
    public class Reptile : Animal,ILegsNum
    {
        public  void Sound()
        {
            Console.Write("we are reptile,");
        }
        public override void Eat()
        {
            Console.WriteLine("we eat meat");
        }
        // <interface>
        public void LegsNumFour()
        {
            Console.WriteLine("I have four legs");
        }
        // child lizzard imhrit from parent reptile
        public class Lizard : Reptile
        {
            public  void Sound()
            {
                Console.Write("im a lizard, my sound is hissing,");
            }
            public  void Tail()
            {
                Console.WriteLine("i have tail");
            }
        }
    }
}