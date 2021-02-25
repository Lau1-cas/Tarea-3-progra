using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas, expo,acum=1 ;
            Console.Write("Ingrese la base de la potencia: ");
            bas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la potencia: ");
            expo = int.Parse(Console.ReadLine());
            for (int i=1;i <=expo; i++)
            {
                acum = acum * bas;

            }
            Console.Write("Resultado : " + acum);
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();

        }
    }
}
