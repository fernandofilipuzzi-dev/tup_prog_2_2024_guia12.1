using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class CentroDespachos
    {
        Queue<Paquete> depositos= new Queue<Paquete>();
        Repartidor camion;

        public CentroDespachos()
        {
            camion = new Repartidor(10);
        }

        public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
        { 
            Paquete nuevo=new Paquete(dni, nombre, direccion);
            depositos.Enqueue(nuevo);
            return nuevo;
        }

        public Repartidor PrepararCamion()
        {
            while (camion.TieneCapacidadDisponible()==true && depositos.Count > 0)
            { 
                camion.Cargar( depositos.Dequeue() );
            }
            return camion;
        }

    }
}
