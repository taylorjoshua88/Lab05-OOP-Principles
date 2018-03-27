using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Feline
{
    public class Cat : Feline
    {
        public override string Name { get; protected set; } = "Cat";
        protected override string Diet { get; set; } = "Fancy Feast";
        public override int FurLength { get; set; } = 3;
    }
}
