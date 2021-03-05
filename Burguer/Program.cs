using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables

            int CantidadHamburguesas, CantidadPapas, CantidadBebidas;
            double total;
            String linea;

            const double PrecioHamburguesa = 45;
            const double PrecioBebida = 15;
            const double PrecioPapas = 20;

            // Pedir datos en la consola
            Console.WriteLine("Ingrese la cantidad de hamburguesas");
            linea = Console.ReadLine();
            CantidadHamburguesas = int.Parse(linea);


            //ordenar papas
            Console.WriteLine("Ingrese la cantidad de Papas");
            linea = Console.ReadLine();
            CantidadPapas = int.Parse(linea);

            //bebidas
            Console.WriteLine("Ingrese la cantidad de bebidas");
           linea = Console.ReadLine();
            CantidadBebidas = int.Parse(linea);


            // calcular el precio a pagar
            total = (CantidadHamburguesas * PrecioHamburguesa) + (CantidadPapas * PrecioPapas) + (CantidadBebidas * PrecioBebida);

            Console.WriteLine("El total a pagar es " + total);
            Console.WriteLine("Presiona cualquier tecla");
            Console.ReadKey();


        }
    }
}
