using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_stack
{
    internal class Pila
    {
        Nodo cima = null;
        int contador = 0;

        public void Push(string nom) //apilar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            contador ++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;

            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Pop() //desapilar
        {
            if(cima != null)
            {
                string nom = cima.Nombre;
                cima = cima.Siguiente;
                contador--;
                return nom;
            }
            return null;
        }

        public string Peek() //vistazo
        {
            if (cima != null)
            {
                return cima.Nombre;
            }
            return null;
        }

        public int Count() //contador de elementos
        {
            return contador;
        }

        public void Clear() //limpiar o destruir
        {
            cima = null;
            contador = 0;
        }
    }
}
