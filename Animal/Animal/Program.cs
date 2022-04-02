using System;
using static Animal.Birds;
using static Animal.Fish;
using static Animal.Insects;
using static Animal.Insects.FlyingBugs;
using static Animal.Mammals;
using static Animal.Reptile;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Birds birds = new Birds();
            birds.Eat();
            birds.LegsNumTWo();
            birds.Fly();
            Console.WriteLine();


            Fish fish = new Fish();
            fish.Eat();
            fish.Tail();
            Console.WriteLine();

            BlueWhale blueWhale = new BlueWhale();
            blueWhale.Color();
            Console.WriteLine();

            Mammals mummals = new Mammals();
            mummals.Sleep();
            mummals.Tail();
            Console.WriteLine();

            BigCats bigCats = new BigCats("lion");
            Console.Write(bigCats.Name);
            Console.WriteLine();
            bigCats.Sleep();
            bigCats.Tail();
            bigCats.LegsNumFour();
            Console.WriteLine();


            Reptile reptile = new Reptile();    
            reptile.Sound();
            reptile.Eat();
            reptile.LegsNumFour();
            Console.WriteLine();

            Lizard lizard = new Lizard();
            lizard.Sound();
            lizard.Tail();
            Console.WriteLine();

            Insects insects = new Insects();
            insects.Eat();
            insects.Fly();
            Console.WriteLine();

            FlyingBugs bug = new FlyingBugs();
            bug.Sound();
            Console.WriteLine();

            Flyingbee flyingbee = new Flyingbee();
            flyingbee.Name = "bee";
            flyingbee.Id = 2;
            Console.Write("name: " + flyingbee.Name);
            Console.Write(" id: " + flyingbee.Id);
        }
    }
}
