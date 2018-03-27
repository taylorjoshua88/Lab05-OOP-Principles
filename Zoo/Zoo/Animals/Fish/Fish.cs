using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish
{
    public abstract class Fish : Animal
    {
        public override int Legs { get; protected set; } = 0;
        protected override string Phrase { get; set; } = "Bloop";

        public override string Move()
        {
            return $"The {Name} swims around happily.";
        }
    }
}
