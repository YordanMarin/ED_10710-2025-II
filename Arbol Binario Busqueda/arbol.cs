using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
{
    internal class arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) return nuevo;
            if (num < actual.numero)
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecha = insertar(actual.derecha, num);
            else MessageBox.Show("No se permiten duplicados!");
            return actual;
        }

        public void preOrden(Nodo actual, TextBox t)
        {
            if(actual != null)
            {
                t.Text += actual.numero.ToString()+" "; //R
                preOrden(actual.izquierda, t); //I
                preOrden(actual.derecha, t); //D
            }
        }

        public void inOrden(Nodo actual, TextBox t)
        {
            if (actual != null)
            {
                inOrden(actual.izquierda, t); //I
                t.Text += actual.numero.ToString() + " "; //R
                inOrden(actual.derecha, t); //D
            }
        }

        public void postOrden(Nodo actual, TextBox t)
        {
            if (actual != null)
            {
                postOrden(actual.izquierda, t); //I
                postOrden(actual.derecha, t); //D
                t.Text += actual.numero.ToString() + " "; //R
            }
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode tallo)
        {
            if (actual != null)
            {
                TreeNode raiz = new TreeNode(actual.numero.ToString()); //R
                if(tallo == null) tree.Nodes.Add(raiz);
                else tallo.Nodes.Add(raiz);

                mostrar(actual.izquierda, tree, raiz); //I
                mostrar(actual.derecha, tree, raiz); //D
            }
        }
    }
}
