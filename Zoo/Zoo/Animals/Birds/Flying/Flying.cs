﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Flying
{
    public abstract class Flying : Bird
    {
        public override int Legs { get; protected set; } = 2;

        public override string Move()
        {
            return $"The {Name} flaps its {Wings} wings and flies away.";
        }
    }
}
