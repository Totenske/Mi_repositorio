using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_11624.Models
{
    internal class Controlador
    {
        public string[] Nombre = new string[100];
        public int[] tiempos = new int[100];
        public int contador = 0;
        public void AgregarCompetidor(string nombre) 
        {
            Nombre[contador] = nombre;
            contador++;
        }
        public void CargarTiempos(int indicecomp, int HH, int MM)
        {
            tiempos[indicecomp] = HH * 60 + MM;
        }
        public void OrderListadorPorTiempo() 
        {
            int aux=0;
            for (int i = 0; i < contador-1; i++) 
            {
                for (int j = i+1; j < contador; i++) 
                {
                    if (tiempos[i] > tiempos[j]) 
                    {
                        tiempos[i] = aux;
                        tiempos[i] = tiempos[j];
                        tiempos[j] = aux;
                    }
                }
            }

        }
    }
}
