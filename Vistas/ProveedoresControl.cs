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
    public partial class UCProveedores : UserControl
    {
        private ProveedorController proveedorController = new ProveedorController();
        public UCProveedores()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            dataGridViewProveedores.DataSource = proveedorController.ObtenerProveedores();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            proveedorController.AgregarProveedor(txtNombre.Text, txtContacto.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
            CargarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["IdProveedor"].Value);
                proveedorController.EliminarProveedor(id);
                CargarProveedores();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["IdProveedor"].Value);
                proveedorController.ActualizarProveedor(id, txtNombre.Text, txtContacto.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
                CargarProveedores();
            }
        }
    }
}
