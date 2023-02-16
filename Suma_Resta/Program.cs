using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_Resta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Programa de suma y resta de cubos **********************");
            Console.WriteLine("\nEste es un programa para resolver sumas o diferencias de cubo");

            Console.WriteLine("\nIntroduzca primer termino");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIntroduzca segundo termino");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y > 0)
            {
                int x3 = x * x * x;
                int y3 = y * y * y;

                int x2 = x * x;
                int y2 = y * y;

                int xy = (-1) * (x * y);

                Console.WriteLine($"({x3}+{y3}) = ({x}+{y})({x2}{xy}+{y2})");

                int total = ((x + y) * (x2 + xy + y2));

                Console.WriteLine("\nSu cubo es " + total);


            }
            else
            {
                int x3 = x * x * x;
                int y3 = y * y * y;
                int my3 = y3 * (-1);
                int my = y * (-1);
                int xy = x * y * (-1);
                int x2 = x * x;
                int y2 = y * y;

                Console.WriteLine($"\n({x3}{y3}) = ({x}{y})({x2}+{xy}+{y2})");

                int total = (x + y) * (x2 + xy + y2);

                Console.WriteLine("\nSu cubo es " + total);
            }
            Console.ReadKey();
        }
    }
}
