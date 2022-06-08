using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6_AnimalAbstrFactory
{
    class Wolf: Carnivore
    {  
        public Wolf()
        {
            Random r = new Random();
            power = r.Next(50, 100); 
        }
        public override void EatMeat(Herbivore h) 
        {
            if (h.weight > power)
            {
                Console.WriteLine("Волк не поел, - 10 сил");
                power -= 10;
            }
            else
            {
                Console.WriteLine("Волк поел, + 10 сил");
                power += 10;
            }
        } 
    }
}
