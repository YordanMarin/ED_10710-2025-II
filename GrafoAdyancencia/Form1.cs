using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoAdyancencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Grafo g = new Grafo(5);
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int o = int.Parse(textOrigen.Text);
            int d = int.Parse(textDestino.Text);
            g.insertarArtista(o, d);
            g.imprimirArista(listBox1, o, d);
            textOrigen.Clear();
            textDestino.Clear();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirmatriz(richTextBox1);
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            textAmplitud.Clear();
            g.amplitud(textAmplitud);
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            textProfundidad.Clear();
            g.profundidad(textProfundidad);
        }
    }
}
