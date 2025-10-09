using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_binario
{
    internal class arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) return nuevo;
            else if((actual.izquierda != null || actual.derecha == null) &&
                (actual.izquierda == null || actual.derecha != null))
            {
                MessageBox.Show("Nodo ocupado");
            }else if(actual.izquierda == null) actual.izquierda = nuevo;
            else actual.derecha = nuevo;

            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode tallo)
        {
            TreeNode ra = new TreeNode(actual.numero.ToString()); //raiz
            ra.Tag = actual;

            if(tallo == null) tree.Nodes.Add(ra); //tallo
            else tallo.Nodes.Add(ra); // hoja

            if (actual.izquierda != null) mostrar(actual.izquierda, tree, ra);
            if (actual.derecha != null) mostrar(actual.derecha, tree, ra);
        }

        public int altura(Nodo actual)
        {
            if(actual != null)
            {
                int altIzd = altura(actual.izquierda);
                int altDer = altura(actual.derecha);

                return Math.Max(altIzd, altDer) +1;
            }
            return 0;
        }
    }
}
