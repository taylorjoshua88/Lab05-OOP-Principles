using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Flying
{
    public class Sparrow : Flying
    {
        protected override string Diet { get; set; } = "Seeds";
        public override string Name { get; protected set; } = "Sparrow";

        public override string Hunt()
        {
            return $"The {Name} forraged for some {Diet}.";
        }
    }
}
