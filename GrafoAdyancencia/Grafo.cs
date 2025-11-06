using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoAdyancencia
{
    internal class Grafo
    {
        int[,] matrizAdyancencia;
        int vertices;

        public Grafo(int vertices)
        {
            this.vertices = vertices;
            matrizAdyancencia = new int[vertices, vertices];
        }

        public void insertarArtista(int o, int d)
        {
            matrizAdyancencia[o, d] = 1;
            //matrizAdyancencia[d, o] = 1; no dirigido
        }
        public void imprimirArista(ListBox list, int o, int d)
        {
            list.Items.Add($"{o} | {d}");
        }

        public void imprimirmatriz(RichTextBox rich)
        {
            for(int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    rich.Text += matrizAdyancencia[i, j]+"\t";
                }
                rich.Text += "\n";
            }
        }

        public void amplitud(TextBox text)
        {
            int inicio = 0;
            bool[] visitado = new bool[vertices];
            Queue<int> cola = new Queue<int>();

            visitado[inicio] = true;
            cola.Enqueue(inicio);

            while(cola.Count() != 0)
            {
                int actual = cola.Dequeue();
                text.Text += actual + " ";

                for(int i = 0;i < vertices; i++)
                {
                    if (matrizAdyancencia[actual, i] ==1 && !visitado[i])
                    {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void profundidad(TextBox text)
        {
            int inicio = 0;
            bool[] visitado = new bool[vertices];
            Stack<int> pila = new Stack<int>();

            visitado[inicio] = true;
            pila.Push(inicio);

            while (pila.Count() != 0)
            {
                int actual = pila.Pop();
                text.Text += actual + " ";

                for (int i = vertices-1; i >=0; i--)
                {
                    if (matrizAdyancencia[actual, i] == 1 && !visitado[i])
                    {
                        visitado[i] = true;
                        pila.Push(i);
                    }
                }
            }
        }
    }
}
