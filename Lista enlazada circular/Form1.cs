using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_circular
{
    public partial class Form1 : Form
    {
        Lista l = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listDatos.Items.Clear();
            l.insertar(int.Parse(textNumero.Text));
            l.mostrar(listDatos);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            l.eliminar(int.Parse(textNumero.Text));
            listDatos.Items.Clear();
            l.mostrar(listDatos);
            textNumero.Clear();
        }
    }
}
