using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** Programa de numeros aleatorios *********************************");

            Random random = new Random();
            List<int> lista = new List<int>();

            Console.WriteLine("\nCuantos numeros aleatorios desea");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese desde que cantidad desea sus numeros aleatorios");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese hasta que cantidad desea sus numeros aleatorios");
            int max = (Convert.ToInt32(Console.ReadLine())) + 1;

            for (int i = 0; i < cantidad; i++)
            {
                int x = random.Next(min, max);
                lista.Add(x);
            }

            Console.WriteLine("\nSus numeros en orden ascendente son");

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i] < lista[j])
                    {
                        int temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("\nSus numeros en orden descendente son");

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i] > lista[j])
                    {
                        int temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
