using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Fabrica
    {
        public static IAnimal GetAnimal(string especie) 
        {
            if (especie == "Pez")
                return new Pez();

            if (especie == "Ave")
                return new Ave();

            else    
                return new Cuadrupedo();
        }
    }
}
