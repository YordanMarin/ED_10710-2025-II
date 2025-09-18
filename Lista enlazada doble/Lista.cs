using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_doble
{
    internal class Lista
    {
        Nodo primero = null;
        Nodo ultimo = null;

        public void insertar(string nom, byte ed)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if(primero == null)
            {
                primero = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            Nodo actual = primero;

            while( actual != null)
            {
                ListViewItem cabe = new ListViewItem(actual.Nombre);
                cabe.SubItems.Add(actual.Edad.ToString());
                list.Items.Add(cabe);
                actual = actual.Siguiente;
            }
        }

        public Nodo buscar(string nombre)
        {
            Nodo actual = primero;

            while( actual != null)
            {
                if( actual.Nombre == nombre)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(string acNom, string nom, byte ed)
        {
            Nodo modificar = buscar(acNom);

            if( modificar != null)
            {
                modificar.Nombre = nom;
                modificar.Edad = ed;
            }
        }

        public void eliminar(string nom)
        {
            Nodo eliminar = buscar(nom);

            if(eliminar == primero)
            {
                primero = primero.Siguiente;
                if( primero != null)
                {
                    primero.Anterior = null;
                }
                
            }else if(eliminar == ultimo)
            {
                ultimo = ultimo.Anterior;
                if(ultimo != null)
                {
                    ultimo.Siguiente = null;
                }
            }
            else
            {
                eliminar.Anterior.Siguiente = eliminar.Siguiente;
                eliminar.Siguiente.Anterior = eliminar.Anterior;
            }
        }
    }
}
