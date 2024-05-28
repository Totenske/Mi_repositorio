using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_28524
{
    class gato
    {
        public bool TieneHambre;
        public string Duenio;
        public void Cazar(Raton r) {
            if (r.Vivo && TieneHambre) {
                r.Vivo = false;
                TieneHambre = false;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int queso = 50;
            gato tom = new gato();


            Raton Jerry = new Raton;
            Jerry.Vivo = true;
        }
    }
}
