using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que almacene los días de la semana en un array y luego mostrarlo*/

            string[] DDLS = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            Console.WriteLine("Los dias de la semana son: \n");
            Console.WriteLine(DDLS[0]);
            Console.WriteLine(DDLS[1]);
            Console.WriteLine(DDLS[2]);
            Console.WriteLine(DDLS[3]);
            Console.WriteLine(DDLS[4]);
            Console.WriteLine(DDLS[5]);
            Console.WriteLine(DDLS[6]);

            Console.ReadKey();
        }
    }
}
