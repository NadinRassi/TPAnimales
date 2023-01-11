using BIbliotecaAnimales.Entidades.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIbliotecaAnimales.Entidades
{
    public class Conejo : Animal
    {
        public Conejo(int edad, double altura, double peso, string color) : base(edad, altura, peso) 
        {
            Color = color;
        }

        public string Color;

        public override string ImprimirComida()
        {
            return "Come zanahoria";
        }

        public override string ImprimirPropiedades()
        {
            return base.ImprimirPropiedades() + "\n¿De qué color es?: " + Color;
        }
    }
}
