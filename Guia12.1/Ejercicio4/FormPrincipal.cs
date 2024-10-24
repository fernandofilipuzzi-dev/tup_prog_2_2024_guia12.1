using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estadistica estadistica=new Estadistica();


            tbVer.Clear();
            foreach (Evento evento in estadistica.ListaEventos())
            {
                tbVer.Text += evento + Environment.NewLine;
            }
            
        }
    }
}
