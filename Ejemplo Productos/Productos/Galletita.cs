using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Productos
    {
        protected float _peso;
        protected bool deConsumo;

        public Galletita(float peso, int codigoBarra, EMarcaProducto marca, float precio) : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
            this.deConsumo = true;
        }

        private string MostrarGalletita()
        {
            return base.Marca.ToString() + " - " + base.Precio.ToString() + " - " + base._codigoBarra.ToString() + " - " + this._peso.ToString();
        }

        public override string ToString()
        {
            return MostrarGalletita();
        }

        public override float CalcularCostoDeProduccion { get { return this.Precio * (float)0.33; } }

        public override string Consumir()
        {
            return "Comestible";
        }

    }
}
