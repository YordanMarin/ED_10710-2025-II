using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoPrim
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

        public void Prim(ListBox list)
        {
            List<int[]> prim = new List<int[]>();
            HashSet<int> visitados = new HashSet<int>();

            int inicio = 0;
            int costoTotal = 0;

            visitados.Add(inicio);

            while (visitados.Count < vertices)
            {
                int[] aristaMinima = null;
                int costoMimimo = int.MaxValue;

                foreach (int verticeArbol in visitados)
                {
                    for(int i = 0;i < vertices; i++)
                    {
                        if (!visitados.Contains(i) && matriz[verticeArbol,i] != 0)
                        {
                            int costoArista = matriz[verticeArbol, i];
                            if (costoArista < costoMimimo)
                            {
                                aristaMinima = new int[] { verticeArbol, i };
                                costoMimimo = costoArista;
                            }
                        }
                    }
                }
                prim.Add(aristaMinima);
                visitados.Add(aristaMinima[1]);
                costoTotal += costoMimimo;

                list.Items.Add($"{aristaMinima[0]}\t{aristaMinima[1]}\t{costoMimimo}");
            }
            list.Items.Add("Costo total = " + costoTotal);
        }
    }
}
