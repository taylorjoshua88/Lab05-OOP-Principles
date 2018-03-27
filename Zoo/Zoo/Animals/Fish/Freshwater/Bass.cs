using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Freshwater
{
    class Bass : Freshwater
    {
        public override string Name { get; protected set; } = "Bass";
        protected override string Diet { get; set; } = "Fish";
    }
}
