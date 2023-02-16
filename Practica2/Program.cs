using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2

// 1- Realizar programa imprima los números primos desde un numero inicial hasta un numero final definido (Valor 1 punto)
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 2;
            int div = 0;

            Console.WriteLine("************************** Programa que despliega numeros primos **************************\n ");
            Console.WriteLine("Ingrese el limite: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            while (num <= cantidad)
               
            {
                for (int i = 1; i <= num; i++) 
                {
                    if (num % i == 0)
                    {
                        div++;
                    }
                    if (div > 2)
                    {
                        break;
                    }
                }

                if (div == 2)
                {
                    Console.WriteLine("{0} es primo ", num);
                }

                div = 0;
                num++;
            }
       
          Console.ReadLine();   
         
        }
        
    }
}
