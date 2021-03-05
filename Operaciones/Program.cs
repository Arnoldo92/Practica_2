using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int num1, num2, resultado;
            String linea;

            // pedir numeros 
            Console.WriteLine("Ingrese el primer numero ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            // operacion de suma 
            resultado = num1 + num2;
            Console.WriteLine("La suma es {0}:", resultado);


            //operacion resta
            resultado = num1 - num2;
            Console.WriteLine("La Resta es {0}:", resultado);

            // Operacion multiplicacion 
            resultado = num1 * num2;
            Console.WriteLine("La multiplicacion es {0}:", resultado);

            // Operacion division 
            resultado = num1 / num2;
            Console.WriteLine("La Divicion  es {0}:", resultado);

            //Operacion division 
            resultado = num1 % num2;
            Console.WriteLine("El residuo es {0}:", resultado);
            Console.WriteLine("Presiona cualquier tecla");
            Console.ReadKey();
        }

    }
}
