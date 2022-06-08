using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class Antilopa: Herbivore
    {  
        public Antilopa()
        {
            Random r = new Random();
            weight = r.Next(50, 80);
            life = true;
        }
        public override void EatGrass() 
        {
            Console.WriteLine("Антилопа поела, + 8 вес");
            weight += 8;
        }
    }
}
