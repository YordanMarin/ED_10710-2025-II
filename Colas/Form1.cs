using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola c = new Cola(); //instancia
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNombre.Text))
            {
                listBox1.Items.Clear();
                c.encolar(textNombre.Text.Trim());
                c.mostrar(listBox1);
                textNombre.Clear();
            }
            else MessageBox.Show("No se permiten valores nulos");
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            string nom = c.desencolar();

            if (nom != null)
            {
                listBox1.Items.Clear();
                c.mostrar(listBox1);
                MessageBox.Show($"{nom} desencolado correctamente");
            }
            else MessageBox.Show("La cola esta vacia");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = c.vistazo();

            if (nom != null)
            {
                MessageBox.Show("Primero en cola: "+nom);
            }
            else MessageBox.Show("La cola esta vacia");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + c.contar());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.limpiar();
            listBox1.Items.Clear();
        }
    }
}
