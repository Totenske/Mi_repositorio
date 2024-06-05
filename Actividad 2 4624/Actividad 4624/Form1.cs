using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_4624
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] notas = new int[100];
        int cont = 0;
        public void ordenar() 
        {
            int guardar;
            for (int i = 0; i < cont - 1; i++) 
            { for (int n = i + 1;n<cont;n++)
                {
                    if (i > n) {
                        guardar = notas[i];
                        notas[i] = notas[n];
                        notas[n] = guardar;
                    }
                }
            }
        
        }
        public int busquedaBinaria(int num) 
        {
            int pivot = 0;
            int minl = 0;
            int maxl = 0;
            int idx = -1;
            while (minl < maxl && idx == -1) 
            {
                pivot = (maxl+minl)/2;
                if (notas[pivot] == num) 
                {
                    idx = pivot;
                }
                if (notas[pivot] > num)
                {
                    maxl = pivot-1;
                }
                if (notas[pivot] < num) 
                {
                 minl = pivot+1;
                }
            }
            return idx;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            notas[cont] = Convert.ToInt32(tbIngreso.Text);
            cont++;
            tbIngreso.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ordenar();
            for (int i = 0; i < cont; i++) 
            {
                lbResultado.Items.Add($"{notas[i]}");
            }
        }
    }
}
