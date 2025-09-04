using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_circular
{
    internal class Lista
    {
        Nodo primero = null;
        Nodo ultimo = null;

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null)
            {
                primero = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListBox list)
        {
            if(primero == null)
            {
                return;
            }
            Nodo actual = primero;

            do
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            } while (actual != primero);
        }

        public void eliminar(int num)
        {
            if (primero == null)
            {
                return;
            }
            Nodo actual = primero;
            Nodo anterior = null;

            do
            {
                if(actual.Numero == num)
                {
                    if(actual == primero)
                    {
                        primero = primero.Siguiente;
                        ultimo.Siguiente = primero;
                        if(primero == actual)
                        {
                            primero = null;
                            ultimo = null;
                        }
                    }else if(actual == ultimo)
                    {
                        ultimo = anterior;
                        ultimo.Siguiente= primero;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != primero);
        }
    }
}
