using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Grafo g;
        private void button1_Click(object sender, EventArgs e)
        {
            g = new Grafo(int.Parse(textVert.Text));
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int o = int.Parse(textOrigen.Text);
            int d = int.Parse(textDestino.Text);
            int c = int.Parse(textCosto.Text);

            g.insertarArista(o, d, c);
            g.imprimirArista(listBox1, o, d, c);
            textOrigen.Clear();
            textDestino.Clear();
            textCosto.Clear();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                richTextBox1.Clear();
                g.imprimirMatriz(richTextBox1);
            }
            else MessageBox.Show("Primero define la cantidad de vertices");
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            g.Prim(listBox2);
        }
    }
}
