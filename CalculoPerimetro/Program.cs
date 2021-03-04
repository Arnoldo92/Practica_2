using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar 3 variables a,b,c y asignarles valores estaticos 

            int a = 10;
            int b = 10;
            int c = 7;

            // Crear una variable de tipo int con la suma guardada de las variables 

            int p = a + b + c;

            //Mostrar en pantalla el valor de total "El perimetro es"
            Console.WriteLine("El perimetro es:" + p);
            Console.WriteLine("Toca alguna tecla para continuar");
            Console.ReadKey();
        }
    }
}
