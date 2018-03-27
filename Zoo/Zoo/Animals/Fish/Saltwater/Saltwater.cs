using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Saltwater
{
    public abstract class Saltwater : Fish
    {
        protected override string Diet { get; set; } = "Plankton";
    }
}
