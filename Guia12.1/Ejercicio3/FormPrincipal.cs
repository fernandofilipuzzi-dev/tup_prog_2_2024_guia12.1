using Ejercicio3.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio3_CentroTaxis
{
    public partial class FormPrincipal : Form
    {
        CentralTaxis central=new CentralTaxis();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            string tel = tbTelefono.Text;
            string direccion = tbDireccion.Text;

            central.RecibirSolicitud(tel, direccion);

            tbTelefono.Clear();
            tbDireccion.Clear();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Movil movil=central.AsignarCoche();
            if (movil == null)
            {
                MessageBox.Show("No hay móvil disponible");
            }
            else
            {
                lbDisponibles.Items.Remove(movil);
                lbOcupados.Items.Add(movil);

                MessageBox.Show($"Móvil Número: {movil.Numero} asignado al cliente: {movil.Pasajero.Telefono}");
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            int numeroMovil = Convert.ToInt32(nupNumeroMovil.Value);
            Movil movil=central.LiberarVehiculo(numeroMovil);

            if (movil == null)
            {
                MessageBox.Show("No se encontró ese móvil");
            }
            else
            {
                lbOcupados.Items.Remove(movil);
                lbDisponibles.Items.Add(movil);
            }
        }
    }
}
