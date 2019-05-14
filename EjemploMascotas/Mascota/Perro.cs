using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre,string raza) : base(nombre,raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre,string raza, int edad,bool esAlfa) : base(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            if(esAlfa == true)
            {
                return this.Nombre+" "+ this.Raza + ", alfa de la Manada, edad " + this.edad.ToString();
            }
            else
            {
                return this.Nombre + " " + this.Raza + " edad " + this.edad.ToString(); 
            }
        }

        public static bool operator == (Perro p1, Perro p2)
        {
            bool retorno = false;

            if(p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Perro p1,Perro p2)
        {
            return !(p1 == p2);
        }


        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }


        public override string ToString()
        {
            return Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                if ((Perro)obj == this)
                {
                    retorno = true;
                }
                else retorno = false;
            }
            return retorno;
        }
    }
}
