using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2, div = 0;
            while (num <= 1000)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        div++;
                    }
                    if (div > 2)
                    {
                        break;
                    }
                }
                if (div == 2)
                {
                    Console.WriteLine("{0} ", num);
                }
                div = 0;
                num++;
            }
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
