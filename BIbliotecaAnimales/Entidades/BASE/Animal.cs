using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIbliotecaAnimales.Entidades.BASE
{
    public abstract class Animal
    {
        public Animal(int edad, double altura, double peso)
        { Edad = edad; Altura = altura; Peso = peso; }
        public int Edad { get; }
        public double Altura { get; }
        public double Peso { get; }

        public virtual string ImprimirPropiedades()
        {
            return "La edad es: " + Edad + " años." + "\nLa altura es: " + Altura + " metros." + "\nEl peso es: " + Peso + " kg.";
        }

        public abstract string ImprimirComida();
    }

}

