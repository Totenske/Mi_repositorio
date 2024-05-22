using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3_14524
{
    internal class Program
    {
        static int Recaudacion = 0;
        #region Menu
        public static void MostarMenu() 
        {
            Console.WriteLine("<------------------------------->");
            Console.WriteLine("1 - Verificar Acceso");
            Console.WriteLine("2 - Imprimir Recaudación");
            Console.WriteLine("3 - Mostrar Cantidad de Accesos");
            Console.WriteLine("Otros salir");
            Console.WriteLine("<------------------------------->");
        }
        #endregion
        #region metodos
        public static void VerificarAcceso() 
        { 
            Console.WriteLine("Ingrese 1 si tiene ticket o 0 de lo contrario");
            int opcion2 = Convert.ToInt32(Console.ReadLine());
            switch (opcion2)
            {
                case 0:
                    {
                        generar_el_ticket();
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Siga a la otra casilla");
                        break;
                    }
            }
        }
        public static void generar_el_ticket() {
            Console.WriteLine("Ingrese el vehiculo con el que entro");
            Console.WriteLine("0 - Sin Vehiculo \n 1 - Moto \n 2 - Auto \n 3 - Camioneta \n 4 - Bugy \n 5 - Vehículo Nautico");
            int Opcion = Convert.ToInt32(Console.ReadLine());
            if (Opcion>0 && Opcion<5) {
            switch (Opcion)
                {
                    case 0: { 
                        
                        }

                        case

                }


            }
        }
        public static void imprimirRecaudacion() {
            Console.WriteLine("R");
        }
        public static void calcularValor() { }
        public static void MostrarAccesos() 
        {
            Console.WriteLine("A");
        }
        #endregion
        #region Main
        static void Main(string[] args)
        {
            int Vehiculos = 0;
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
                            Vehiculos++;
                            break;
                        }
                    case 2: {
                            imprimirRecaudacion();
                            break;
                            }

                    case 3: {
                            MostrarAccesos();
                            Console.WriteLine(Vehiculos);
                            break;
                            }
                }
                MostarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bye Bye (°_°)");
            Console.ReadKey();

        }
        #endregion
    }
}
