using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ProyectoMercadoSY
{
    public class Conexion
    {
        private readonly string connectionString = "Server = TERBS; Database = SYMercadoDbo; Integrated Security = true";
        private SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection(connectionString);
        }
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la BD" + ex.Message);
            }
        }
        public void CerrarConexion()
        {
            conexion.Close();
        }
        public DataTable Logear(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Vusuario WHERE idusuario = @usuario AND clave = @pass", conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@pass", contraseña);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la BD: " + ex.Message);
            }

            return dt;
        }
       
    }
}

