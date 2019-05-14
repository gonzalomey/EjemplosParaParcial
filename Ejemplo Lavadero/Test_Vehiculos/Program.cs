using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Test_Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
      Auto nuevoAuto = new Auto("111 AAA",4, EMarca.Ford, 4);
      Moto nuevaMoto = new Moto("222 BBB", 2, EMarca.Zanella, 8);
      Camion nuevoCamion = new Camion("333 CCC", 6, EMarca.Iveco, 2000);

      //List<Vehiculo> vehiculos = new List<Vehiculo>();
      //vehiculos.Add(nuevoAuto);
      //vehiculos.Add(nuevaMoto);
      //vehiculos.Add(nuevoCamion);
     


      Lavadero lavadero = new Lavadero( 1000, 2000, 3000);

      lavadero += nuevoAuto;
      lavadero += nuevaMoto;
      lavadero += nuevoCamion;

      //Console.WriteLine(nuevoAuto.ToString());
      //Console.WriteLine(nuevaMoto.ToString());
      //Console.WriteLine(nuevoCamion.ToString());

      Console.WriteLine(lavadero.MiLavadero);

      Console.WriteLine(lavadero.MostrarTotalFacturado());
      Console.ReadLine();

      lavadero -= nuevoAuto;

      Console.WriteLine(lavadero.MiLavadero);

      Console.WriteLine(lavadero.MostrarTotalFacturado());
      Console.ReadLine();





    }
  }
}
