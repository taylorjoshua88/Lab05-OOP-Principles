using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Rodent
{
    public class Mouse : Rodent
    {
        public override string Name { get; protected set; } = "Mouse";
        protected override string Diet { get; set; } = "Cheese";
        public override int FurLength { get; set; } = 0;
    }
}
