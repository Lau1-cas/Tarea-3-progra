using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_tarea_3_progra
{
    class Program
    {
        static void Main(string[] args)
        {
			int num, i;
			float result = 1;
			string linea;
			Console.Write("Introduce un numero : ");
			linea = Console.ReadLine();
			num = Int32.Parse(linea);
			for (i = 2; i <= num; i++)
			{
				result = result * i;
			}
			Console.WriteLine("El factorial de {0} es {1}", num, result);
			Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
