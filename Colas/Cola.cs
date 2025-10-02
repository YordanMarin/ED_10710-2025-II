using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    internal class Cola
    {
        Nodo primero = null;
        Nodo ultimo = null;
        int cant = 0;

        public void encolar(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if(primero == null)
            {
                primero = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            cant++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string desencolar()
        {
            if(primero != null)
            {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cant--;
                return nom;
            }
            return null;
        }

        public string vistazo()
        {
            if (primero != null)
            {
                return primero.Nombre;
            }
            return null;
        }

        public int contar()
        {
            return cant;
        }

        public void limpiar()
        {
            primero = null;
            ultimo = null;
            cant = 0;
        }
    }
}
