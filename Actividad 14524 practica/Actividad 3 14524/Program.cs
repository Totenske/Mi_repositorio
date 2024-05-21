using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3_14524
{
    internal class Program
    {
        public static void MostarMenu() 
        {
            Console.WriteLine("1 - Verificar Acceso");
            Console.WriteLine("2 - Imprimir Recaudación");
            Console.WriteLine("3 - Mostrar Cantidad de Accesos");
            Console.WriteLine("Otros salir");
        }
        public static void VerificarAcceso() 
        { 
            Console.WriteLine("V");
        }
        public static void imprimirRecaudacion() {
            Console.WriteLine("R");
        }
        public static void MostrarAccesos() 
        {
            Console.WriteLine("A");
        }
        static void Main(string[] args)
        {
            int opcion;
            MostarMenu();
            opcion=Convert.ToInt32(Console.ReadLine());
            while (opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            VerificarAcceso();
                            break;
                        }
                    case 2: {
                            imprimirRecaudacion();
                            break;
                            }

                    case 3: {
                            MostrarAccesos();
                            break;
                            }
                }
                MostarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bye Bye (°_°)");
            Console.ReadKey();

        }
    }
}
