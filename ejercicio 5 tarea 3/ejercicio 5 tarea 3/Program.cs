using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,l,n,p,op,A,P;

            System.Console.WriteLine("Ingrese la opcion que desee: ");
            System.Console.WriteLine("1... sacar el perimetro de un triangulo regular");
            System.Console.WriteLine("2... sacar el area de un triangulo regular");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case 1:
                    System.Console.WriteLine("Ingrese el numero de lados: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la medida de los lados: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    p = l * n;
                    Console.Write("El perimetro es de: " + p);
                    break;

                case 2:
                    System.Console.WriteLine("Ingrese el perimetro del triangulo: ");
                    P = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la apotema del triangulo: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    A = P * a / 2;
                    Console.Write("El area es de: " + A);
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();


        }
    }
}
