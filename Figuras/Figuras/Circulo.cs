using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Circulo : IFigura
    {
        public void Dibujar()
        {
            Console.WriteLine("Se ha dibujado un Circulo.");
        }
    }
}
