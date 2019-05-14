using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Productos
    {

        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public EMarcaProducto Marca { get { return _marca; } }
        public float Precio { get { return _precio; } }

        public Productos(int codigoBarra, EMarcaProducto marca,float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        private string MostrarProducto()
        {
            return this._marca.ToString() + " - " + this._codigoBarra.ToString() + " - " + this._precio.ToString();
        }

        public static bool operator ==(Productos p1, Productos p2)
        {
            bool retorno = false;

            if (p1._marca == p2._marca && p1._codigoBarra == p2._codigoBarra)
                retorno = true;

            return retorno;
        }


        public static bool operator !=(Productos p1, Productos p2)
        {
            bool retorno = false;

            if (!(p1 == p2))
                retorno = true;

            return retorno;
        }

        public static bool operator ==(Productos p1, EMarcaProducto m1)
        {
            bool retorno = false;

            if (p1._marca == m1)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Productos p1, EMarcaProducto m1)
        {
            bool retorno = false;

            if (!(p1 == m1))
                retorno = true;

            return retorno;
        }

        public static implicit operator string(Productos p)
        {
            return p.MostrarProducto();           
        }

        public static explicit operator int(Productos p)
        {
            return p._codigoBarra;
        }

        public abstract float CalcularCostoDeProduccion { get; }

        public virtual string Consumir()
        {
            return "Parte De Una Mezcla";
        }

        public override bool Equals(object obj)
        {
            return obj is Productos && this == (Productos)obj; 
        }
    }
}
