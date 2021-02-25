using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, totalmenores = 0, totalmayores = 0, edadmenor, edadmayor = 0, suma = 0, i = 0;
            int acum = 0;

            Console.Write("\nIngrese la edad de la persona: ");
            edad = int.Parse(Console.ReadLine());
            edadmenor = edad;
           
            for (int j = 1; j <= 5; j++)
            {
                acum = acum + edad;
                 }

                while (edad > 0)
            {
                suma = suma + edad;
                i++;
                if (edad <= 17)
                    totalmenores = totalmenores + 1;
                else
                    totalmayores = totalmayores + 1;

                if (edad > edadmayor)
                    edadmayor = edad;
                if (edad < edadmenor)
                    edadmenor = edad;
                Console.Write("\nIngrese la edad de la persona: ");
                edad = int.Parse(Console.ReadLine());
            }

            Console.Write("El promedio es: " + acum);
            Console.Write("\nTotal de menores:" + totalmenores);
            Console.Write("\nTotal de mayores:" + totalmayores);
            Console.Write("\nEdad mayor:" + edadmayor);
            Console.Write("\nEdad menor:" + edadmenor);
            
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();

        }
    }
}
