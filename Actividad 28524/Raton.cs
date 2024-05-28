using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_28524
{
    public class Raton
    {
        public bool TieneHambre;
        public bool Vivo;
        public void Comer(ref int queso)
        {

            if (Vivo == true)
            {
                if (queso >= 2)
                {
                    TieneHambre = true;
                    queso -= 2;
                }
                else { if (queso <= 1) 
                    {
                      
                    } 
                }
            }

        }
    }
}
