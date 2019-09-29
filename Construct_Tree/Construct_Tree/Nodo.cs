using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Tree
{
    class Nodo<T>
    {
        public T Value { get; set; }
        public Nodo<T> hijoder { get; set; }
        public Nodo<T> hijoizq { get; set; }
        public int Factorequi { get; set; }
        public Nodo(T value)
        {
            Value = value;
            hijoder = null;
            hijoizq = null;
            Factorequi = 0;
        }
    }
}
