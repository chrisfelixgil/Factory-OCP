using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Animales
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Pez");
            Console.WriteLine("Ave");
            Console.WriteLine("Cuadrupedo");
            Console.Write("Escriba el animal del cual quiere conocer si habitad: ");
            string opcion = Console.ReadLine();

            IAnimal oAnimal = Fabrica.GetAnimal(opcion);
            oAnimal.Habitad();
            Console.ReadKey();
            Main(args);
        }
    }
}
