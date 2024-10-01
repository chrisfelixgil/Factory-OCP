using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Pez : IAnimal
    {
        public void Habitad() 
        {
            Console.WriteLine("Este animal vive en el agua.");
        }
    }
}
