using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    internal abstract class Carnivore
    {
        public int power { get; set; }
        public abstract void EatMeat(Herbivore h); 
    }
}
