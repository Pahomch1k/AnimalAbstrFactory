using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class Lion: Carnivore
    { 
        public Lion()
        {
            Random r = new Random();
            power = r.Next(80, 120);
        }
        public override void EatMeat(Herbivore h)
        {
            if (h.weight > power)
            {
                Console.WriteLine("Лев не поел, - 8 сил");
                power -= 8;
            }
            else
            {
                Console.WriteLine("Лев поел, + 8 сил");
                power += 8;
                h.life = false;
            }
        }
    }
}
