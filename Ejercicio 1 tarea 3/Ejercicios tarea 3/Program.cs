using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2==0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();

        }
    }
}
