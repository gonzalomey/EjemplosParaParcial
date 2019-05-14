using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        public double cilindrada;
       

        private string MostrarMoto()
        {
            string retorno;

            retorno = base.ToString() +" - " + this.cilindrada.ToString();

            return retorno;
        }

    public override string ToString()
    {
      return this.MostrarMoto(); 
    }

    public Moto(string p, int cr, EMarca m, double cili) : base(p, cr, m)
        {
            this.cilindrada = cili;
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
