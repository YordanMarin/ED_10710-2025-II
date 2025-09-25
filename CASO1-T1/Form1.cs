using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASO1_T1
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
            string talla = textTallas.Text;

            if (talla.Contains("."))
            {
                string[] partes = talla.Split('.');

                if (partes[0].Length == 1)
                {
                    if (partes[1].Length > 0)
                    {
                        if (double.TryParse(talla, out double t) && t > 0)
                        {
                            if (l.insertar(t))
                            {
                                listBox1.Items.Clear();
                                l.mostrar(listBox1);
                                textTallas.Clear();
                            }
                            else
                                MessageBox.Show("No se permiten duplicados");
                        }
                        else
                        {
                            MessageBox.Show("No se permite vacios ni negativos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiene que ser almenos 1 decimal1");
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que ser solo 1 entero!");
                }
            }
            else
            {
                MessageBox.Show("Tiene que ingresar el punto decimal");
            }
        }
    }
}
