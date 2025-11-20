using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoFloyd
{
    internal class Grafo
    {
        int[,] matriz;
        int vertices;

        public Grafo(int vertices)
        {
            this.vertices = vertices;
            matriz = new int[vertices, vertices];
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    rich.Text += matriz[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void insertarArista(int o, int d, int c)
        {
            matriz[o, d] = c;
        }

        public void imprimirArista(ListBox list, int o, int d, int c)
        {
            list.Items.Add($"{o} | {d} | {c}");
        }

        public void floyd(RichTextBox rich)
        {
            int[,] floyd = new int[vertices, vertices];
            //copiando los valores e la matriz de costo
            //remplazando 0 -> infinito (int.MaxValue)
            for(int i = 0;i < vertices; i++)
            {
                for(int j = 0;j < vertices; j++)
                {
                    if(matriz[i, j] != 0)
                        floyd[i, j] = matriz[i, j];
                    else 
                        floyd[i, j] = int.MaxValue;
                }
            }

            //aplicar floyd warshall

            for(int k= 0; k < vertices; k++)
            {
                for(int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (floyd[i,k] != int.MaxValue && floyd[k,j] != int.MaxValue)
                        {
                            int nuevoCosto = floyd[i,k] + floyd[k,j];
                            if (nuevoCosto < floyd[i,j])
                            {
                                floyd[i, j] = nuevoCosto;
                            }
                        }
                    }
                }
            }

            //imprimir floyd warshall
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (i == j)
                        rich.Text += "0\t";
                    else if (floyd[i, j] == int.MaxValue)
                        rich.Text += "∞\t";
                    else rich.Text += floyd[i, j]+"\t";

                }
                rich.Text += "\n";
            }
        }
    }
}
