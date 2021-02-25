using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int num;
			System.Console.WriteLine("Ingrese un numero: ");
			num = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(num + "x" + i + "=" + (i * num));
			}
			Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
			Console.ReadKey();

		}
	}
}
