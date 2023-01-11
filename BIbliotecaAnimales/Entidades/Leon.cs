using BIbliotecaAnimales.Entidades.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIbliotecaAnimales.Entidades
{
    public class Leon : Animal
    {
        public Leon(int edad, double altura, double peso, bool tieneMelena) : base(edad, altura, peso) 
        {
            TieneMelena = tieneMelena;
        }

        public bool TieneMelena;

        public override string ImprimirComida()
        {
            return "Come carne";
        }

        public override string ImprimirPropiedades()
        {
            return base.ImprimirPropiedades() + "\n¿Tiene melena?: " + TieneMelena;
        }
    }
}
