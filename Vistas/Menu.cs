using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenParcial2.Modelos;
using ExamenParcial2.Vistas;

namespace ExamenParcial2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_Productos_Click(object sender, EventArgs e)
        {
            ProductosControl productosuc = new ProductosControl();
            panelPrincipal.Controls.Clear();
            productosuc.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(productosuc);
        }

        private void button_ReporteStock_Click(object sender, EventArgs e)
        {
            ReportesStock reportes = new ReportesStock();
            panelPrincipal.Controls.Clear();
            reportes.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(reportes);
        }

        private void button_Entradas_Click(object sender, EventArgs e)
        {
            EntradasControl entradas = new EntradasControl();
            panelPrincipal.Controls.Clear();
            entradas.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(entradas);
        }

        private void button_Proveedores_Click(object sender, EventArgs e)
        {
            UCProveedores proveedores = new UCProveedores();
            panelPrincipal.Controls.Clear();
            proveedores.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(proveedores);
        }
    }
}
