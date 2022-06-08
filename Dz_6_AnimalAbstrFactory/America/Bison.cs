using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class Bison: Herbivore
    {  
        public Bison()
        {
            Random r = new Random();
            weight = r.Next(70, 100);
            life = true;
        } 
        public override void EatGrass() 
        {
            Console.WriteLine("Бизон поел, + 10 вес");
            weight += 10;
        } 
    }
}
