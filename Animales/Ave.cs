﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Ave : IAnimal
    {
        public void Habitad()
        {
            Console.WriteLine("Este animal vive en la copa de los arboles.");
        }
    }
}
