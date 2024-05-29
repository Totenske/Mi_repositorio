using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acitividad_primos
{
    internal class Program
    {
        static public bool EsPrimo(int nro) {
            return !EsDivisible( nro, nro-1);
        }

        static public bool EsDivisible(int nro, int d) {
            if (d > 2) {
                return nro % d == 0 || EsDivisible(nro, d - 1);
            }
            else { return (nro % 2 == 0); }
        }
        static void Main(string[] args)
        {
            int inf = 5;
            int sup = 10;

            for (int i = inf; i <= sup; i++) {

                if (EsPrimo(i)) {
                    Console.Write("{0}", i + " - ");
                }
            }
            Console.ReadKey();
        }
    }
}
