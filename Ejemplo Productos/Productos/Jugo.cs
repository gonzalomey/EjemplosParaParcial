using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Productos
    {
        protected ESaborJugo _sabor;
        protected bool deConsumo;

        public Jugo(ESaborJugo sabor, int codigoBarra, EMarcaProducto marca, float precio) :base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
            this.deConsumo = true;
        }

        private string MostrarJugo()
        {
            return base.Marca.ToString() + " - "+ base.Precio.ToString() + " - "+ base._codigoBarra.ToString()+ " - "+ this._sabor.ToString();
        }

        public override string ToString()
        {
            return MostrarJugo();
        }

        public override float CalcularCostoDeProduccion { get {return this.Precio * (float)0.4 ;} }

        public override string Consumir()
        {
            return "Bebible";
        }

    }
}
