using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Programa que pide al usuario 5 números reales utilizando float 
             y luego los muestra en el orden contrario al que se introdujeron.
             */

            float[] N = new float[5];
            string option = "";
            while (option.ToLower() != "n")
            {
                Console.Write("Digite el primer numero: ");
                N[0] = float.Parse(Console.ReadLine());
                Console.Write("Digite el segundo numero: ");
                N[1] = float.Parse(Console.ReadLine());
                Console.Write("Digite el tercer numero: ");
                N[2] = float.Parse(Console.ReadLine());
                Console.Write("Digite el cuarto numero: ");
                N[3] = float.Parse(Console.ReadLine());
                Console.Write("Digite el quinto numero: ");
                N[4] = float.Parse(Console.ReadLine());

                Console.WriteLine("\nLa inversa de los numeros digitados es: \n");

                Console.WriteLine(N[4]);
                Console.WriteLine(N[3]); 
                Console.WriteLine(N[2]);
                Console.WriteLine(N[1]);
                Console.WriteLine(N[0]);

                Console.WriteLine("\nReintentar: S"
                + "\nSalir: N");
                option = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
