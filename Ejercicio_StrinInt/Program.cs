using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StrinInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            int edad;


            //valor a numero 

             
            // Pedir por consola el nombre de una persona 
            Console.WriteLine("Por favor escribe tu nombre ");
            nombre = Console.ReadLine();

            // Escribir la edad 
            Console.WriteLine("Escribe tu edad por favor");
            edad = int.Parse(Console.ReadLine());

            //Mostrar en pantalla 
            Console.WriteLine("Te llamas" + nombre + " y tienes" + edad);
            Console.WriteLine("Presiona cualquier tecla para continuar: " );
            Console.ReadKey();
        }
    } 
}
