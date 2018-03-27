using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Freshwater
{
    public abstract class Freshwater : Fish
    {
        protected override string Diet { get; set; } = "Worms";
    }
}
