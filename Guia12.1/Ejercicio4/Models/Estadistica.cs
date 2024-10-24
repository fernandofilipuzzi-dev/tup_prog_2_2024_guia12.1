using libEstructuras;
using System.Collections.Generic;

namespace Ejercicio4.Models
{
    public class Estadistica
    {
        private ArbolNArio<Evento> probalidades { get; set; } = new ArbolNArio<Evento>();

        public Estadistica()
        {
            //evento A
            Evento A = new Evento("A", 1.0);
            probalidades.Agregar(A);

            //evento B Y c 
            NodoNArio<Evento> nodoA = probalidades.BuscarNodo(A);
            probalidades.Agregar( new Evento("B", 0.7), nodoA);
            probalidades.Agregar( new Evento("C", 0.3), nodoA);

            //eventos condicionales de B
            NodoNArio<Evento> nodoB = probalidades.BuscarNodo(new Evento("B", 0));
            probalidades.Agregar(new Evento("D", 0.6), nodoB);
            probalidades.Agregar(new Evento("E", 0.4), nodoB);

        }

        public List<Evento> ListaEventos()
        {
            return probalidades.ListarNodos(probalidades.Raiz);
        }
     }
}

