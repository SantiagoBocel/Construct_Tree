using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Tree
{
    class Program
    {
        static Arbol_ABB Arbol = new Arbol_ABB();
        static void Main(string[] args)
        {
            Console.WriteLine("Arbol ABB");
            int orden;
            int contador = 0;
            do
            {
                Console.WriteLine("\n //////////////////////////////////////");
            Inicio:
                Console.WriteLine("1. Ingresar Letra");
                Console.WriteLine("2. In-orden");
                Console.WriteLine("3. Pre-orden");
                orden = Convert.ToInt32(Console.ReadLine());
                contador++;
                switch (orden)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresar letra {0}:", contador);
                        string letra = Console.ReadLine();
                        Arbol.Add(letra);
                        goto Inicio;
                    case 2:
                        Console.Clear();
                        Arbol.Mostrar2();
                        break;
                    case 3:
                        Console.Clear();
                        Arbol.Mostrar1();
                        break;
                }
            } while (orden != 4);
            
         }
    }
}

