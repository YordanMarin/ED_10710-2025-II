using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB2
{
    internal class Nodo
    {
        public int numero {  get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecha { get; set; }

        public Nodo(int num)
        {
            numero = num;
            izquierda = null;
            derecha = null;
        }
    }
}
