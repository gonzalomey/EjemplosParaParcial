using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Gaseosa : Productos
    {
        protected float _litros;
        protected bool deConsumo;

        public Gaseosa(float litros, int codigoBarra, EMarcaProducto marca, float precio) : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
            this.deConsumo = true;
        }

        private string MostrarGaseosa()
        {
            return base.Marca.ToString() + " - " + base.Precio.ToString() + " - " + base._codigoBarra.ToString() + " - " + this._litros.ToString();
        }

        public override string ToString()
        {
            return MostrarGaseosa();
        }

        public override float CalcularCostoDeProduccion { get { return this.Precio * (float)0.42; } }

        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
