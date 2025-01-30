using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenParcial2.Controladores;

namespace ExamenParcial2.Modelos
{

    public partial class EntradasControl : UserControl
    {
        private EntradaController entradaController = new EntradaController();
        public EntradasControl()
        {
            InitializeComponent();
            CargarEntradas();
        }
        private void CargarEntradas()
        {
            dataGridViewEntradas.DataSource = entradaController.ObtenerEntradas("");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewEntradas.DataSource = entradaController.ObtenerEntradas(txtBuscar.Text);
        }
    }
}
