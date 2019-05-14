using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected int cantidadRuedas;
        protected EMarca marca;

        public string Patente
        {
            get { return patente; }            
        }

        public  EMarca Marca
        {
            get { return marca; }
        }

    public abstract double Precio { get; set; }

    public abstract double CalcularPrecioConIva();


    protected string MostrarVehiculo()
        {
            string retorno;

            retorno = this.patente + " - "  + this.cantidadRuedas.ToString() + " - " + this.marca;

            return retorno;
        }

        public override string ToString()
        {
          return this.MostrarVehiculo(); 
        }

    protected Vehiculo(string patente,int cantidadRuedas,EMarca marca)
        {
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno= false;

            if (v1.marca == v2.marca && v1.patente == v2.patente)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (!(v1 == v2))
                retorno = true;

            return retorno;
        }

    }
}
