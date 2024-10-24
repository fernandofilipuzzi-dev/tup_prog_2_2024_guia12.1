using System;

namespace Ejercicio3.Models
{
    public class Movil : IComparable<Movil>
    {
        public int Numero { get; private set; }
        public Pedido Pasajero { get; set; }

        public Movil(int numero)
        { }

        public int CompareTo(Movil other)
        {
            if(other !=null) return Numero.CompareTo(other.Numero);
            return 1;
        }
    }
}

