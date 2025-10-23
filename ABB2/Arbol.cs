using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB2
{
    internal class Arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) return nuevo;
            if (num < actual.numero)
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecha = insertar(actual.derecha, num);
            else MessageBox.Show("No duplicados");
            return actual;
        }

        public void mostrar(Nodo actual, TreeView t, TreeNode tallo)
        {
            if(actual != null)
            {
                TreeNode raiz = new TreeNode(actual.numero.ToString());
                if(tallo == null) t.Nodes.Add(raiz);
                else tallo.Nodes.Add(raiz);

                mostrar(actual.izquierda, t , raiz);
                mostrar(actual.derecha, t, raiz);
            }
        }

        public Nodo buscar(Nodo actual, int num)
        {
            if (actual != null)
            {
                if (num == actual.numero) return actual;
                else if (num < actual.numero)
                    return buscar(actual.izquierda, num);
                else 
                    return buscar(actual.derecha, num);
            }
            return null;
        }

        public Nodo eliminar(Nodo actual, int num)
        {
            if(actual != null)
            {
                if(num < actual.numero) 
                    actual.izquierda = eliminar(actual.izquierda, num);
                else if(num > actual.numero)
                    actual.derecha = eliminar(actual.derecha,num);
                else
                {
                    //CASO 1: CUANDO TIENE 1 SOLO HIJO
                    if (actual.izquierda == null) return actual.derecha;
                    if(actual.derecha == null) return actual.izquierda;

                    //CASO 2: CUANDO TIENE 2 HIJOS
                    Nodo sucesor = minimo(actual.derecha);
                    actual.numero = sucesor.numero;
                    actual.derecha = eliminar(actual.derecha, sucesor.numero);
                }
            }
            return actual;
        }

        public Nodo minimo(Nodo actual)
        {
            while(actual.izquierda != null)
                actual = actual.izquierda;
            return actual;
        }
    }
}
