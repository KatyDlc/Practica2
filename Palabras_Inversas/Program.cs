using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5- Realizar programa que que invierta el sentido de las palabras, ejemplo PRUEBA = ABERUP

namespace Palabras_Inversas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** Programa que invierte palabras ***********************");

            String f1 = " ", f2 = " ";
            Console.WriteLine("\nIngrese la palabra a invertir: ");
            f1= Console.ReadLine();

            for (int i = f1.Length -1; i >= 0; i--) 
            {
                f2 += f1[i];
            }

            Console.WriteLine("\nLa frase invertida es: " + f2);
            Console.ReadLine();
        }
    }
}
