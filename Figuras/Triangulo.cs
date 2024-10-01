using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo : IFigura               
    {
        private static Triangulo instance;
        public Triangulo() { }
        public static Triangulo GetInstance() 
        {
            if(instance == null)
                instance = new Triangulo();
            return instance;
        }

        public void Dibujar() 
        {
            Console.WriteLine("Se ha dibujado un Triangulo.");
        }
    }
}
