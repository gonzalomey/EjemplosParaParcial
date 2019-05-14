using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {

        public int cantidadAsientos;
       

        private string MostrarAuto()
        {
            string retorno;

            retorno = base.ToString() + " - " + this.cantidadAsientos.ToString();

            return retorno;
        }

    public override string ToString()
    {
      return this.MostrarAuto(); 
    }

    public Auto(string p, int cr, EMarca m, int ca) : base(p, cr, m)
        {
            this.cantidadAsientos = ca;
        }

    public override double Precio
    {
      get { return this.Precio; }
      set { this.Precio = value; }
    }

    public override double CalcularPrecioConIva()
    {

      return this.Precio += (this.Precio / 0.21);

    }
  }
}
