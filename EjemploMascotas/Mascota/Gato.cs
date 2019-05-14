using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {

        public Gato(string nombre,string raza) : base(nombre,raza)
        {

        }

        protected override string Ficha()
        {
            return this.Nombre + " " + this.Raza;
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if(g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
            {
                if ((Gato)obj == this)
                {
                    retorno = true;
                }
                else retorno = false;
            }
            return retorno;
        }
    }
}
