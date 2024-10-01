using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Circulo");
            Console.WriteLine("Triangulo");
            Console.WriteLine("cuadrado");
            Console.Write("Escribe la figura que quieres dibujar: ");
            string opcion = Console.ReadLine();

            IFigura oFigura = Fabrica.GetFigura(opcion);

            oFigura.Dibujar();
            Console.ReadKey();
            Main(args);
        }
    }
}
