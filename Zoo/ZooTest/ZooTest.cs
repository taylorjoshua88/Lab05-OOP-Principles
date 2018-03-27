using System;
using Xunit;

namespace ZooTest
{
    public class ZooTest
    {
        [Fact]
        public void OstrichIsBird()
        {
            Zoo.Animals.Birds.Grounded.Ostrich ostrich = new Zoo.Animals.Birds.Grounded.Ostrich();

            Assert.True(ostrich is Zoo.Animals.Birds.Bird);
        }

        [Fact]
        public void DodoIsDead()
        {
            Zoo.Animals.Birds.Grounded.Dodo dodo = new Zoo.Animals.Birds.Grounded.Dodo();

            Assert.False(dodo.CheckPulse());
        }

        [Fact]
        public void RobinIsFlyingBird()
        {
            Zoo.Animals.Birds.Flying.Robin robin = new Zoo.Animals.Birds.Flying.Robin();

            Assert.True(robin is Zoo.Animals.Birds.Flying.Flying);
        }

        [Fact]
        public void SparrowHuntsForSeeds()
        {
            Zoo.Animals.Birds.Flying.Sparrow sparrow = new Zoo.Animals.Birds.Flying.Sparrow();

            Assert.Equal($"The Sparrow forraged for some Seeds.", sparrow.Hunt());
        }

        [Fact]
        public void EagleIsAnimal()
        {
            Zoo.Animals.Birds.Flying.Raptor.Eagle eagle = new Zoo.Animals.Birds.Flying.Raptor.Eagle();

            Assert.True(eagle is Zoo.Animals.Animal);
        }

        [Fact]
        public void HawkIsRaptor()
        {
            Zoo.Animals.Birds.Flying.Raptor.Hawk hawk = new Zoo.Animals.Birds.Flying.Raptor.Hawk();

            Assert.True(hawk is Zoo.Animals.Birds.Flying.Raptor.Raptor);
        }

        [Fact]
        public void BluegillHasNoLegs()
        {
            Zoo.Animals.Fish.Freshwater.Bluegill bluegill = new Zoo.Animals.Fish.Freshwater.Bluegill();

            Assert.Equal(0, bluegill.Legs);
        }

        [Fact]
        public void BassEatsFish()
        {
            Zoo.Animals.Fish.Freshwater.Bass bass = new Zoo.Animals.Fish.Freshwater.Bass();

            Assert.Equal("The Bass enjoyed eating Fish!", bass.Eat());
        }
        
        [Fact]
        public void SardineIsSaltwaterFish()
        {
            Zoo.Animals.Fish.Saltwater.Sardine sardine = new Zoo.Animals.Fish.Saltwater.Sardine();

            Assert.True(sardine is Zoo.Animals.Fish.Saltwater.Saltwater);
        }

        [Fact]
        public void TigerSharkSaysBloop()
        {
            Zoo.Animals.Fish.Saltwater.TigerShark tigerShark = new Zoo.Animals.Fish.Saltwater.TigerShark();

            Assert.Equal("The Tiger Shark says Bloop", tigerShark.Speak());
        }

        [Fact]
        public void MouseEatsCheese()
        {
            Zoo.Animals.Mammal.Rodent.Mouse mouse = new Zoo.Animals.Mammal.Rodent.Mouse();

            Assert.Equal("The Mouse enjoyed eating Cheese!", mouse.Eat());
        }

        [Fact]
        public void ChipmunkCannotMolt()
        {
            Zoo.Animals.Mammal.Rodent.Chipmunk chipmunk = new Zoo.Animals.Mammal.Rodent.Chipmunk();

            Assert.Contains("cannot molt", chipmunk.Molt());
        }

        [Fact]
        public void LionHasFiveCentimeterFur()
        {
            Zoo.Animals.Mammal.Feline.Lion lion = new Zoo.Animals.Mammal.Feline.Lion();

            Assert.Equal(5, lion.FurLength);
        }

        [Fact]
        public void CatEatsFancyFeast()
        {
            Zoo.Animals.Mammal.Feline.Cat cat = new Zoo.Animals.Mammal.Feline.Cat();

            Assert.Equal("The Cat enjoyed eating Fancy Feast!", cat.Eat());
        }
    }
}
