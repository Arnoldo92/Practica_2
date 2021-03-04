using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_string
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String ciudad;

            // Pedir por consola el nombre de una persona 
            Console.WriteLine("Por favor escribe tu nombre");
            nombre = Console.ReadLine();

            // Pedir el nombre de una ciudad
            Console.WriteLine("Escribe tu ciudad");
            ciudad = Console.ReadLine();

            //Mostrar en pantalla 
            Console.WriteLine("Hola" + nombre + "Bienvenido a " + ciudad);
            Console.WriteLine("Presiona cualquier tecla");
            Console.ReadKey();

        }
    }
}
