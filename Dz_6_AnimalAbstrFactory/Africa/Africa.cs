using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class Africa : IContinent
    {
        public Herbivore CreateHerbivores() => new Antilopa();
        public Carnivore CreateCarnivores() => new Lion();
    }
}
