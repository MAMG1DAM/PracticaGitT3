using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_control_de_versiones_tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioButton1.Checked)
                tipoTelegrama = 'u';
            if (radioButton2.Checked)
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?

            if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama

            numPalabras = textoTelegrama.Length;


            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')

            {
                if (numPalabras <= 10)

                    coste = 2.5;

                else
                    coste = (0.5 * numPalabras) - 2.5;


                txtPrecio.Text = coste.ToString() + " euros";
            }
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = (0.75 * numPalabras) - 5;
            }
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
