using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _cantidad;
        protected List<Productos> _productos;

        private Estante()
        {
            this._productos = new List<Productos>();
        }

        public Estante(sbyte cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public List<Productos> GetProducto()
        {
            return this._productos;
        }

        public string MostrarEstante()
        {
            string retorno = "";

            foreach (Productos p in this._productos)
            {

                retorno += p.ToString() + "\n";

            }
            return retorno;
        }


    }
}
