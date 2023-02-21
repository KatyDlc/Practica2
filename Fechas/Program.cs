using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************** Programa de calculo de semanas entre dos fechas ***************************)");

            Console.WriteLine("\nIngrese la primera fecha en formato DD/MM/AAAA ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese la segunda fecha en formato DD/MM/AAAA");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan diferencia = fecha2 - fecha1;
            int semanas = (int)(diferencia.TotalDays / 7);

            if (semanas < 0)
            {
                semanas = semanas * (-1);
            }

            Console.WriteLine("El número de semanas entre las dos fechas es: " + semanas);
            Console.ReadKey();
        }
    }
}
