using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenParcial2.Modelos;

namespace ExamenParcial2.Controladores
{
    public class ProveedorController
    {
        public string connectionString = "Server=.;Database=ExamenParcial2;Trusted_Connection=True;";
        public DataTable ObtenerProveedores()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerProveedores", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void AgregarProveedor(string nombre, string contacto, string telefono, string email, string direccion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarProveedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarProveedor(int idProveedor, string nombre, string contacto, string telefono, string email, string direccion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProveedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EliminarProveedor(int idProveedor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
