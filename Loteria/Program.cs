using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************** Programa de loteria ********************************");

            Console.WriteLine("\nLos numeros de su loteria son: ");

            List<int> list = new List<int>();

            for (int i = 0; i < 3; i++)
            {

                Random random = new Random();

                int x = random.Next(0, 100);

                if (x == 0)
                {
                    i--;
                }
                else
                {
                    list.Add(x);
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
