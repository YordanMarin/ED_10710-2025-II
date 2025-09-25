using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO1_T1
{
    internal class Nodo
    {
        private double talla;
        private Nodo siguiente;
        private Nodo anterior;

        public double Talla { get => talla; set => talla = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
    }
}
