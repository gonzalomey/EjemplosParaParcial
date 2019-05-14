using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {

        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        public static ETipoManada Tipo { set { tipo = value; } }


        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo() 
        {
           this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) :this(nombre)
        {
            Tipo = tipo;
        }

        public static bool operator ==(Mascota m, Grupo g)
        {
            bool retorno = false;
            foreach (Mascota ma in g.manada)
            {
                if (m == ma)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Mascota m, Grupo g)
        {
            return !(m == g);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {

            if (m != g)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine("La mascota ya se encuentra en la Manada.");
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (m == g)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine("La mascota no se encuentra en la Manada.");
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            string retorno = "";

            retorno += "Grupo:"+ g.nombre + " - Tipo: " + Grupo.tipo+ " \n";
            retorno += "Integrantes<" + g.manada.Count+">:\n";
            foreach (Mascota m in g.manada)
            {
                retorno += m.ToString()+ "\n";
            }

            return retorno;
        }


    }
}
