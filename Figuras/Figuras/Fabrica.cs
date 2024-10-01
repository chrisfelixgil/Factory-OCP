using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Fabrica
    {
        public static IFigura GetFigura(string objeto) 
        {
            if(objeto.ToLower() == "triangulo")
                return Triangulo.GetInstance();

            if (objeto.ToLower() == "circulo")
                return new Circulo();

            else
                return new Cuadrado();
            
            
        }
    }
}
