using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_14524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador=0;
            Console.WriteLine("ingrese el numero a verificar");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                contador++;
                }
            }
            if (contador <= 2) {
                Console.WriteLine("Es primo");
            }
            else { Console.WriteLine("No es primo"); }
            Console.ReadKey();
        }
    }
}
