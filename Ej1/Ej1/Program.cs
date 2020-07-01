using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Programa que pide al usuario 4 números, los memoriza (utilizando una tabla)
            y luego calcula la media aritmética moestrando en pantalla 
            la media y los datos tecleados.
            */

            int[] N = new int[4];
            int media;
            string option = "";

            while (option.ToLower() != "n")
            {
                Console.Write("Digite el primer numero: ");
                N[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el segundo numero: ");
                N[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el tercer numero: ");
                N[2] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el cuarto numero: ");
                N[3] = Convert.ToInt32(Console.ReadLine());

                media = (N[0] + N[1] + N[2] + N[3]) / 4;
                Console.WriteLine("\nLa media de {0},{1},{2},{3} es: " 
                + media, N[0], N[1], N[2], N[3]);

                Console.WriteLine("\nReintentar: S"
                + "\nSalir: N");
                option = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
