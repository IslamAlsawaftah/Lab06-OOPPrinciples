using System;
using Xunit;
using Animal;
using Animal.Classes;

namespace TestProject1
 
{
    public class UnitTest1
    {
        Insects insects = new Insects();
        Reptile reptile = new Reptile();
        Birds birds = new Birds();
        Fish fish = new Fish();
        Mammals mammals = new Mammals();
        BigCats bigCats = new BigCats("Lion");

       
        [Fact]
        public void TestImplementILegsNumInterface()
        {
           Assert.Equal("I have four legs", reptile.LegsNum());
        }
        [Fact]
        public void TestImplementBirdsILegsNumInterface()
        {
            Assert.Equal("I have two legs", birds.LegsNum());
        }
        [Fact]
        public void TestImplementFlyInterface()
        {
            Assert.Equal("i can fly", insects.Fly());
        }

        [Fact]
        public void TestImplementBirdsIfly()
        {
            Assert.Equal("i can fly", birds.Fly());
        }
        [Fact]
        public void TestInsects()
        {
            Assert.Equal("im bee i eat honey,", insects.Eat());
        }
        [Fact]
        public void TestFishTail()
        {
            Assert.Equal("we have tail", fish.Tail());

        }
        [Fact]
        public void TestMammalsSleep()
        {
          Assert.Equal("4 hours per day,", mammals.Sleep());
        }
        [Fact]
        public void Testoverridden()
        {
            Assert.Equal("we are birds we eat meat and vegetables", birds.Eat());
        }
        [Fact]
        public void TestIsAnimal()
        {
            Assert.True(typeof(Mammals).IsSubclassOf(typeof(Animal.Animal)));
        }
    }
}
