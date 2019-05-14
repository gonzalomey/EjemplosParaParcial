using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        
        public double tara;

        private string MostrarCamion()
        {
            string retorno;

            retorno = base.ToString() +" - " +this.tara.ToString();

            return retorno;
        }

    public override string ToString()
    {
      return this.MostrarCamion(); 
    }

    public Camion(string p,int cr,EMarca m,double t) : base(p,cr,m)
        {
            this.tara = t;
        }

    public override double Precio {
      get { return this.Precio; }
      set { this.Precio = value; }
    }

    public override double CalcularPrecioConIva()
    {

     return this.Precio += (this.Precio / 0.21);

    }

  }
}
