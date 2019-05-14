using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Lavadero
    {

        //ATRIBUTOS
        private double precioAuto;
        private double precioMoto;
        private double precioCamion;


        //CONSTRUCTOR LAVADERO
        public Lavadero(double pa, double pm, double pc) : this()
        {          
            this.precioAuto = pa;
            this.precioMoto = pm;
            this.precioCamion = pc;
        }

        private List<Vehiculo> _vehiculos;
        private Lavadero()
        {
          this._vehiculos = new List<Vehiculo>();
        }


    #region//PROPIEDAD SOLO LECTURA MiLavadero
    public string MiLavadero
        {
            get
            {
                string retorno = "";

               // retorno += this.precioAuto+"-"+this.precioMoto+"-"+this.precioCamion;

                foreach (Vehiculo v in this._vehiculos)
                {

                  retorno += v.ToString() +"\n";

                }
                    return retorno;
            }
        }
        #endregion


        //PROPIEDAD SOLO LECTURA DE LA LISTA
        public List<Vehiculo> Vehiculos { get { return this._vehiculos;} }

        #region//SOBRECARGA OPERADOR ==

        public static bool operator == (Vehiculo v,Lavadero l)
        {
            bool retorno = false;
            foreach(Vehiculo ve in l._vehiculos )
            {
                if (v == ve)
                    retorno = true;
            }
            return retorno;
        }
        #endregion

        #region//SOBRECARGA OPERADOR !=
        public static bool operator !=(Vehiculo v, Lavadero l)
        {
           return !(v == l);
        }
        #endregion

        #region//SOBRECARGA OPERADOR +
        public static Lavadero operator +(Lavadero l,Vehiculo v)
        {
           
                if(v != l)
                {
                    l._vehiculos.Add(v);
                }

            return l;
        }
#endregion

        #region//SOBRECARGA OPERADOR -
        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {

                if (v == l)
                {
                    l._vehiculos.Remove(v);
                }


            return l;
        }
        #endregion


        #region//SOBRECARGAS DE METODO MOSTRARTOTALFACTURADO
        public double MostrarTotalFacturado()        
        {
            double acum = 0;
            
            acum += (MostrarTotalFacturado(EVehiculos.Auto)) + (MostrarTotalFacturado(EVehiculos.Camion)) + (MostrarTotalFacturado(EVehiculos.Moto));                
            
            return acum;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
            {
                double acum = 0;
                foreach(Vehiculo v in this._vehiculos)
                {
                    if(vehiculos is EVehiculos.Auto && v is Auto)
                    {
                        acum += this.precioAuto;
                    }
                   if(vehiculos is EVehiculos.Moto && v is Moto)
                    {
                        acum += this.precioMoto;
                    }
                   if(vehiculos is EVehiculos.Camion && v is Camion)
                    {
                        acum += this.precioCamion;
                    }
                }

                return acum;
            }

        #endregion


        #region//ORDENAMIENTOS
        public static int OrdenarPorPatente(Vehiculo v1, Vehiculo v2)
            {
                int retorno;
                    
                if(v1.Patente.CompareTo(v2.Patente) == 1)
                {
                    retorno = 1;
                }
                else if(v1.Patente == v2.Patente)
                {
                    retorno = 0;
                }
                else
                {
                    retorno = -1;
                }

                return retorno;
            }


        public int OrdenarPorMarca(Vehiculo v1, Vehiculo v2)
            {
                int retorno;
                    
                if(v1.Marca > v2.Marca)
                {
                    retorno = 1;
                }
                else if(v1.Marca == v2.Marca)
                {
                    retorno = 0;
                }
                else
                {
                    retorno = -1;
                }

                return retorno;
            }
        #endregion
    }
}
