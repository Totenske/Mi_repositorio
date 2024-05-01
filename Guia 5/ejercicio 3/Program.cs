using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lista,mayor_nota=0,nota,menor_nota=10,nro_libreta,menor_lib=0,mayor_lib=0;
            string nombre, nombremayor="xxxx",nombremenor="yyyy";
            Console.WriteLine("Introduzca el numero de almunos");
            lista = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lista; i++)
            {
                Console.WriteLine("ingrese el nro de libreta, nombre del alumno y su nota");
                nro_libreta = Convert.ToInt32(Console.ReadLine());
                nombre = Console.ReadLine();
                nota = Convert.ToInt32(Console.ReadLine());
                if (nota > mayor_nota)
                {
                    mayor_nota = nota;
                    nombremayor = nombre;
                    mayor_lib = nro_libreta;
                }
                if (nota < menor_nota)
                {
                    nombremenor = nombre;
                    menor_nota = nota;
                    menor_lib = nro_libreta;
                }
            }
            Console.WriteLine("La mayor nota es {0}, con nombre {1} y libreta {2}",mayor_nota,nombremayor,mayor_lib);
            Console.WriteLine("La menor nota es {0}, con nombre {1} y libreta {2}",menor_nota,nombremenor,menor_lib);
            Console.ReadKey();
        }
    }
}
