using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Tree
{
    interface Iarbol_ABB
    {
        void Add(string dato);
        void Comparar(Nodo<string> nuevo, Nodo<string> Padre, bool HIJO);
        void Mostrar2();
        void Mostrar1();
        void PreOrden(Nodo<string> Raiz);
        void InOrden(Nodo<string> Raiz);
    }
}
