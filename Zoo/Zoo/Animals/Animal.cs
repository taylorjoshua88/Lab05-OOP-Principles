using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        public abstract string Name { get; protected set; }
        protected abstract string Diet { get; set; }
        protected abstract string Phrase { get; set; }
        public virtual int Legs { get; protected set; } = 4;
        public virtual bool IsAlive { get; set; } = true;

        public string Eat()
        {
            return $"The {Name} enjoyed eating {Diet}!";
        }

        public string Speak()
        {
            return $"The {Name} says {Phrase}";
        }

        public abstract string Move();

        public virtual string Molt()
        {
            return $"The {Name} cannot molt!";
        }

        public bool CheckPulse()
        {
            return IsAlive;
        }
    }
}
