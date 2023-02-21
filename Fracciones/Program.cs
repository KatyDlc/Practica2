using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************** Programa para convertir fracciones mixtas a impropias **********************************\n");

            Console.WriteLine("Ingrese parte entera de su fraccion");
            int entero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese numerador");
            int numerador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngreso denominador");
            int denominador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nSu fraccion es {entero} {numerador}/{denominador}");

            int numeradorm = (entero * denominador) + numerador;

            Console.WriteLine($"\n Su fraccion convertida es: {numeradorm}/{denominador}");
            Console.ReadKey();
        }
    }
}
