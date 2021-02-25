using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1, num, i, c;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            for(i=0;i < num; i++)
            {
                c = a;
                a = b;
                b = c + a;
                Console.WriteLine(a);
            }
            
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
			Console.ReadKey();
		}
	}
}
