using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_6_AnimalAbstrFactory
{
    class Client
    {  
        public void Main()
        {    
            WriteLine("Client: America");
            ClientMethod(new America());
            WriteLine();

            WriteLine("Client: Africa");
            ClientMethod(new Africa());
        }
          
        public void ClientMethod(IContinent factory)
        {
            var Herbivores = factory.CreateHerbivores();
            var Carnivores = factory.CreateCarnivores();

            WriteLine(Herbivores.life);
            WriteLine(Herbivores.weight);
            Herbivores.EatGrass();
            WriteLine(Herbivores.weight);


            WriteLine(Carnivores.power);
            Carnivores.EatMeat(Herbivores);
            WriteLine(Carnivores.power);
            WriteLine(Herbivores.life);
        }
    }
}
