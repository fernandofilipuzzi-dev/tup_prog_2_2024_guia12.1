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
      
        CentroDespachos centro=new CentroDespachos();
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
            int dni=Convert.ToInt32(tbDNI.Text);
            string nombre = tbDireccion.Text;
            string direccion = tbDireccion.Text;

            Paquete registrado=centro.RecibirCorrespondencia(dni, nombre, direccion);

            lbxVerSectorCarga.Items.Add(registrado);

            tbDNI.Clear();
            tbDireccion.Clear();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            camion=centro.PrepararCamion();

            lbxHistorialEntregas.Items.Clear();
        }

        private void btnReparto_Click(object sender, EventArgs e)
        {
            Paquete p=camion.Descargar();

            lbxHistorialEntregas.Items.Add(p);
        }
    }
}
