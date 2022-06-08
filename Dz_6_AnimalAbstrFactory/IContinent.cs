using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    interface IContinent
    {
        public Herbivore CreateHerbivores();
        public Carnivore CreateCarnivores();
    }
}
