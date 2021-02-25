using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, total_pagar;
            string producto;

            Console.WriteLine("Ingrese el nombre del producto");
            producto = Console.ReadLine();
           
            if (producto !="medicina")
            {
                System.Console.WriteLine("Ingrese el total de su compra: ");
                total = Convert.ToInt32(Console.ReadLine());
                total_pagar = total * 0.12;
                Console.Write("Usted debe pagar un total de: " + total_pagar);

            }
            else
            {
                System.Console.WriteLine("Ingrese el total de su compra: ");
                total = Convert.ToInt32(Console.ReadLine());
                Console.Write("Usted debe pagar un total de: " + total);
            }
                
                  
        Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();



        }
    }
}
