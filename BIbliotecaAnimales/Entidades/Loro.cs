using BIbliotecaAnimales.Entidades.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIbliotecaAnimales.Entidades
{
    public class Loro : Animal
    {
        public Loro(int edad, double altura, double peso, bool habla):base(edad, altura, peso) 
        {
            Habla = habla;
        }

        public bool Habla;

        public override string ImprimirComida()
        {
            return "Come semillas";
        }

        public override string ImprimirPropiedades()
        {
            return base.ImprimirPropiedades() + "\n¿Habla?: " + Habla;
        }
    }
}
