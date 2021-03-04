using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar tres variables int y agregarles valores estaticos 

            int numero_1 = 5;
            int numero_2 = 20;
            int numero_3 = 10;

            // paso 2 crear una variable de tipo inti la cual guardara la suma
            int suma = numero_1 + numero_2 + numero_3;

            // paso numero 3 mostrar el pantalla el valor de suma con el siguiente mensaje
            //"el valor de suma es "
            Console.WriteLine("El valor de la suma es : " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();




        }
    }
}
