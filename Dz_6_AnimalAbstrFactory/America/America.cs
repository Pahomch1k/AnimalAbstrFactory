using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class America: IContinent
    {
        public Herbivore CreateHerbivores() => new Bison();
        public Carnivore CreateCarnivores() => new Wolf(); 
    }
}
