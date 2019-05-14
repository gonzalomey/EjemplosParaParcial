using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Productos
    {
        protected ETipoHarina _tipo;
        protected bool deConsumo;

        public Harina(ETipoHarina tipo, int codigoBarra, EMarcaProducto marca, float precio) : base(codigoBarra, marca, precio)
        {
            this._tipo = tipo;
            this.deConsumo = true;
        }

        private string MostrarHarina()
        {
            return base.Marca.ToString() + " - " + base.Precio.ToString() + " - " + base._codigoBarra.ToString() + " - " + this._tipo.ToString();
        }

        public override string ToString()
        {
            return MostrarHarina();
        }

        public override float CalcularCostoDeProduccion { get { return this.Precio * (float)0.6; } }


    }
}
