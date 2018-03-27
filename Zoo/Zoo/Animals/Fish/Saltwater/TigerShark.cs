using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Saltwater
{
    public class TigerShark : Saltwater
    {
        public override string Name { get; protected set; } = "Tiger Shark";
        protected override string Diet { get; set; } = "Fish";
    }
}
