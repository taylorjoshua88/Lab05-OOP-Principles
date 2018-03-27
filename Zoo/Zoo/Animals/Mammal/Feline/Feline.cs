﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        protected override string Phrase { get; set; } = "Meow";

        public override string Move()
        {
            return $"The {Name} slinks around on its {Legs} legs suspiciously.";
        }
    }
}
