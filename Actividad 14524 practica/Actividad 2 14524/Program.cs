using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_14524
{
    internal class Program
    {
        public static bool esPrimo(int numero) {
            int contador = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador <= 2)
            {
                return true;
            }
            else {return false;} 
        } 
        static void Main(string[] args)
        {
            int desde=0, hasta=0;
            bool verificar;
            Console.WriteLine("Numero inicial");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero final");
            hasta = Convert.ToInt32(Console.ReadLine());
            for (int i = desde; i <= hasta; i++) 
            {
                verificar = esPrimo(i);
                if (verificar == true) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
