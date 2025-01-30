using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenParcial2.Controladores;

namespace ExamenParcial2.Modelos
{
    public partial class ProductosControl : UserControl
    {
        private ProductoController productoController = new ProductoController();
        private ProveedorController proveedorController = new ProveedorController();

        public ProductosControl()
        {
            InitializeComponent();
            CargarProveedores();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dataGridViewProductos.DataSource = productoController.BuscarProducto("");
        }

        private void CargarProveedores()
        {
            DataTable dtProveedores = proveedorController.ObtenerProveedores();

            comboBoxProveedores.DataSource = dtProveedores;
            comboBoxProveedores.DisplayMember = "Nombre";
            comboBoxProveedores.ValueMember = "IdProveedor";
            if (comboBoxProveedores.Items.Count > 0)
            {
                comboBoxProveedores.SelectedIndex = 0;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewProductos.DataSource = productoController.BuscarProducto(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxProveedores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor válido antes de continuar.");
                return;
            }
            int idProveedor = Convert.ToInt32(comboBoxProveedores.SelectedValue);
            if (idProveedor == 0)
            {
                MessageBox.Show("Seleccione un proveedor válido.");
                return;
            }
            productoController.AgregarProducto(
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToDecimal(txtPrecio.Text),
                Convert.ToInt32(txtStock.Text),
                idProveedor
            );
            CargarProductos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["IdProducto"].Value);
                productoController.EliminarProducto(idProducto);
                CargarProductos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                int idProveedor = Convert.ToInt32(comboBoxProveedores.SelectedValue);
                int id = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["IdProducto"].Value);
                productoController.ActualizarProducto(
                id,
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToDecimal(txtPrecio.Text),
                Convert.ToInt32(txtStock.Text),
                idProveedor
                );
                CargarProductos();
            }
        }
    }

}
