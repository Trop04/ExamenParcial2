using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenParcial2.Modelos;
using System.Windows.Forms;

namespace ExamenParcial2.Controladores
{
    public class ProductoController
    {
        public string connectionString = "Server=.;Database=ExamenParcial2;Trusted_Connection=True;";

        public void AgregarProducto(string nombre, string descripcion, decimal precio, int stock, int idProveedor)
        {
            if (idProveedor == 0)
            {
                MessageBox.Show("Seleccione un proveedor válido.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor); //29-01 17:23 checar sql server para ver si esto si sirve

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarProducto(int IdProducto, string nombre, string descripcion, decimal precio, int stock, int idProveedor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarProducto(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
