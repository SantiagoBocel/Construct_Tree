using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Tree
{
    class Arbol_ABB: Iarbol_ABB
    {
        static Nodo<string> Raiz { get; set; }
        #region Metodos
        public void Add(string dato)
        {
            var nuevo = new Nodo<string>(dato);
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                // comparar si el nuevo elemento es mayor (1) o menor(-1) a la raiz
                bool HIJO = nuevo.Value.CompareTo(Raiz.Value) > 0;
                Comparar(nuevo, Raiz, HIJO);

            }
        }
        public void Comparar(Nodo<string> nuevo, Nodo<string> Padre, bool HIJO)
        {
            #region si es derecho
            if (HIJO)
            {
                if (Padre.hijoder == null)
                {
                    Padre.hijoder = nuevo;
                }
                else
                {
                    bool HIJOder = nuevo.Value.CompareTo(Padre.hijoder.Value) > 0;
                    Comparar(nuevo, Padre.hijoder, HIJOder);
                }
            }
            #endregion
            #region si es izquierdo
            else
            {

                if (Padre.hijoizq == null)
                {
                    Padre.hijoizq = nuevo;
                }
                else
                {
                    bool HIJOizq = nuevo.Value.CompareTo(Padre.hijoizq.Value) > 0;
                    Comparar(nuevo, Padre.hijoizq, HIJOizq);
                }
            }
            #endregion
        }

        public void InOrden(Nodo<string> Raiz)
        {
            if (Raiz.hijoizq == null)
            {
                InOrden(Raiz.hijoder);
            }
            else
            {
                InOrden(Raiz.hijoizq);
                Console.WriteLine(Raiz.Value);
                InOrden(Raiz.hijoder);
            }
        }
        #region Mostar arbol
        public void Mostrar1()
        {
            PreOrden(Raiz);
        }

        public void Mostrar2()
        {
            InOrden(Raiz);
        }

        public void PreOrden(Nodo<string> Nodo)
        {
                Console.WriteLine(Nodo.Value);
            if (Nodo.hijoder == null)
            {
                PreOrden(Nodo.hijoizq);
            }
            else
            {
                PreOrden(Nodo.hijoder);
            }
            if (Nodo == null && Nodo.hijoder == null && Nodo.hijoizq == null && Nodo.Value == null)
            {
                Console.WriteLine("Fin");
            }
        }
        #endregion
    }
    #endregion
}
