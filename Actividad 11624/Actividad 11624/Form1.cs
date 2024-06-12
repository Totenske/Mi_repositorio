using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_11624.Models;

namespace Actividad_11624
{
    public partial class Form1 : Form
    {
        Controlador controlador = new Controlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                controlador.AgregarCompetidor(form2.txCompetidor.Text);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            for (int i = 0; i < controlador.contador; i++) 
            {
                if (form3.ShowDialog()==DialogResult.OK) 
                {
                    int hh = Convert.ToInt32(form3.TxHH.Text);
                    int mm = Convert.ToInt32(form3.txMM.Text);
                    controlador.CargarTiempos(i, hh, mm);
                }
            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            controlador.OrderListadorPorTiempo();
            if (form4.ShowDialog() == DialogResult.OK) 
            {
                for (int i = 0; i < controlador.contador; i++) 
                {

                }
            }
        }
    }
}
