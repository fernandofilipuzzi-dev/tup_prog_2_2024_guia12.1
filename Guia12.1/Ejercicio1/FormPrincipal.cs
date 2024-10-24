using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{

    public partial class FormPrincipal : Form
    {

        CentroDespachos centro = new CentroDespachos();
        Repartidor camion;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDNI.Text);
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            Paquete registrado = centro.RecibirCorrespondencia(dni, nombre, direccion);

            lbxVerSectorCarga.Items.Add(registrado);

            tbDNI.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {


            FormDatoCamion fDatoCamion = new FormDatoCamion();
            if (fDatoCamion.ShowDialog() == DialogResult.OK)
            {
                int capacidad = Convert.ToInt32(fDatoCamion.nupCapacidad.Value);

                camion = centro.PrepararCamion(capacidad);

                Paquete paquete = null;
                do
                {
                   paquete=centro.CargarPaqueteAlCamion();

                    if (paquete != null)
                    {
                        //lo quita del sector de embarque
                        lbxVerSectorCarga.Items.Remove(paquete);

                        //lo paso al plan de entregas.
                        lbxListadoAEntregar.Items.Add(paquete);
                    }
                } while (paquete != null);
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            if (camion != null)
            {
                btnReparto.Enabled = true;

                Paquete paquete= camion.Revisar();

                if (paquete != null)
                {
                    lbDNI.Text = paquete.DNIRemitente.ToString();
                    lbNombre.Text = paquete.NombreRemitente;
                    lbDireccion.Text = paquete.Direccion;
                }
            }
            else
            {
                MessageBox.Show("No hay camión preparado");
            }
        }

        private void btnReparto_Click(object sender, EventArgs e)
        {
            Paquete p = camion.Descargar();

            lbxListadoAEntregar.Items.Add(p);
        }


    }
}
