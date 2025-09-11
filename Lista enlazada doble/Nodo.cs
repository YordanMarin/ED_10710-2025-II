using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_doble
{
    internal class Nodo
    {
        private string nombre;
        private byte edad;
        private Nodo siguiente;
        private Nodo anterior;

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
    }
}
