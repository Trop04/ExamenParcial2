using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2.Controladores
{
    public class EntradaController
    {
        private string connectionString = "Server=.;Database=ExamenParcial2;Trusted_Connection=True;";

        public void AgregarEntrada(int idProducto, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarEntrada", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerEntradas(string busqueda)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEntradas", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda", busqueda);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
