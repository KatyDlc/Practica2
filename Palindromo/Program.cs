using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 4- Realizar programa que determine si una cadena de texto es un pálindromo.


namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** Programa que determina si una palabra es palindromo ******************");
            Console.WriteLine("Ingrese la palabra: ");
            string contenedor = Console.ReadLine();
            bool palindromo = true;

            string pAlReves = "";
           for (int i = contenedor.Length - 1; i >= 0; i--)
            {
                char letras = Convert.ToChar(contenedor[i]);
                pAlReves += letras.ToString();
            }


            if (contenedor == pAlReves)
            {
                palindromo = false;
            }

            if (palindromo == true) 
            {
                Console.WriteLine("No es palindromo.");
            }
            else if (palindromo == false)
            {
                Console.WriteLine("La palabra ingresada es un palindromo");
            }

            Console.ReadLine(); 
        }
    }
}
