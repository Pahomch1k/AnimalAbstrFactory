using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    abstract class Herbivore
    {
        public int weight { get; set; }
        public bool life { get; set; }
        public abstract void EatGrass(); 
    }
}
