using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi,resultado,resultado2;
            pi = 3.1416;
            int rad,op,grad;

            Console.WriteLine("Ingrese la opción que desea");
            Console.WriteLine("opcion 1..... convertir de radianes a grados");
            Console.WriteLine("Opcion 2..... convertir de grados a radianes");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case 1:
                    System.Console.WriteLine("Ingrese el numero de radianes para convertirlos en grados: ");
                    rad = Convert.ToInt32(Console.ReadLine());
                    resultado = rad * 180 / pi;
                    Console.Write("El resultado es: " + resultado);
                    break;

                case 2:
                    System.Console.WriteLine("Ingrese el numero de grados para convertirlos en  radianes: ");
                    grad = Convert.ToInt32(Console.ReadLine());
                    resultado2 = grad * pi / 180;
                    Console.Write("El resultado es: " + resultado2);
                    break;

            default: Console.WriteLine("Opcion inexistente.");
                    break;
        }
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();

        }
    }
}
