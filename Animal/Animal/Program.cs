using System;
using static Animal.Fish;
using static Animal.Insects;
using static Animal.Insects.FlyingBugs;
using static Animal.Mammals;
using static Animal.Reptile;
using static Animal.Birds;

namespace Animal
{
    public class Program
    {
        static void Main(string[] args)
        {

            Mammals mummals = new Mammals();
            Console.WriteLine(mummals.Sleep());
            Console.WriteLine(mummals.Tail());
            Console.WriteLine();

            Fish fish = new Fish();
            Console.WriteLine(fish.Eat());
            Console.WriteLine(fish.Tail());
            Console.WriteLine();

            BlueWhale blueWhale = new BlueWhale();
            Console.WriteLine(blueWhale.Color());
            Console.WriteLine();

            Birds birds = new Birds();
            Console.WriteLine(birds.Eat());
            Console.WriteLine(birds.LegsNum());
            Console.WriteLine(birds.Fly());
            Console.WriteLine();


            BigCats bigCats = new BigCats("lion");
            Console.Write(bigCats.Name);
            Console.WriteLine();
            Console.WriteLine(bigCats.Sleep());
            Console.WriteLine(bigCats.Tail());
            Console.WriteLine(bigCats.LegsNum());
            Console.WriteLine();


            Reptile reptile = new Reptile();
            Console.WriteLine(reptile.Sound());
            Console.WriteLine(reptile.Eat());
            Console.WriteLine(reptile.LegsNum());
            Console.WriteLine();

            Lizard lizard = new Lizard();
            Console.WriteLine(lizard.Sound());
            Console.WriteLine(lizard.Tail());
            Console.WriteLine();

            Insects insects = new Insects();
            Console.WriteLine(insects.Eat());
            Console.WriteLine(insects.Fly());
            Console.WriteLine();

            FlyingBugs bug = new FlyingBugs();
            Console.WriteLine(bug.Sound());
            Console.WriteLine();

            Flyingbee flyingbee = new Flyingbee();
            flyingbee.Name = "bee";
            flyingbee.Id = 2;
            Console.Write("name: " + flyingbee.Name);
            Console.Write(" id: " + flyingbee.Id);
        }
    }
}