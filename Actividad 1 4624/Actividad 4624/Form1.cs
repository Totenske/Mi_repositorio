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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static double acum;
        static int contador;
        static double CalcularPromedio() 
        {
            double promedio = 0;
            if (contador > 0) 
            {
                promedio = acum / contador;
            }
            return promedio;
        }
        private void RegistrarNota(double nota) 
        {
            acum += nota;
            contador++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(TBAgregar.Text);
            RegistrarNota(nota);

            TBAgregar.Clear();
        }

        private void BTNPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();

            labelpromedio.Text = $"{promedio:f2}";
        }
    }
}
