using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3.Models
{
    public class CentralTaxis
    {
        Queue<Movil> movilesDisponibles=new Queue<Movil>();
        LinkedList<Movil> movilesOcupados = new LinkedList<Movil>();

        Queue<Pedido> pedidos = new Queue<Pedido>();
        
        public CentralTaxis()
        {
        }

        public void RecibirSolicitud(string tel, string direccion)
        {
            Pedido nuevo = new Pedido(tel, direccion);
            pedidos.Enqueue(nuevo);
        }

        public Movil AsignarCoche()
        {
            Movil disponible = null;//me va a indicar si fue exitosa la asignación
            if (movilesDisponibles.Count > 0 && pedidos.Count > 0)
            { 
                disponible=movilesDisponibles.Dequeue();
                Pedido pedido = pedidos.Dequeue();

                disponible.Pasajero = pedido;

                movilesOcupados.AddLast(disponible);
                return disponible;
            }
            return disponible;
        }

        public Movil LiberarVehiculo(int numero)
        {
            Movil libre = null;//me va a indicar si fue exitosa la asignación

            LinkedListNode<Movil> nodo = movilesOcupados.First;
            while (nodo!=null && libre==null)
            {
                libre = nodo.Value;
                nodo=nodo.Next;
            }

            if (libre != null)
            {
                libre.Pasajero = null;//desvinculo con el pedido/cliente/pedido
                movilesDisponibles.Enqueue(libre);
            }
                       
            return libre;
        }
    }
}
