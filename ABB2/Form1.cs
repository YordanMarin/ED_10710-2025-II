using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo raiz;
        Arbol a = new Arbol();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num) && (num >= 0 & num <= 20))
            {
                if (raiz == null) raiz = a.insertar(null, num);
                else a.insertar(raiz, num);

                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else MessageBox.Show("Solo se permiten números entre 0 a 20");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num) && (num >= 0 & num <= 20))
            {
                Nodo buscar = a.buscar(raiz, num);

                if (buscar != null)
                    MessageBox.Show($"El número {num} si existe");
                else 
                    MessageBox.Show($"El número {num} no existe");
            }
            else MessageBox.Show("Solo se permiten números entre 0 a 20");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num) && (num >= 0 & num <= 20))
            {
                Nodo buscar = a.buscar(raiz, num);

                if (buscar != null)
                {
                    raiz = a.eliminar(raiz, num);
                    treeView1.Nodes.Clear();
                    a.mostrar(raiz, treeView1 , null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                } 
                else
                    MessageBox.Show($"No se puede eliminar. El número {num} no existe");
            }
            else MessageBox.Show("Solo se permiten números entre 0 a 20");
        }
    }
}
