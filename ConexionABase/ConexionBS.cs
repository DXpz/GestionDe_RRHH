using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_RRHH.ConexionABase
{
    public class ConexionBD
    {
        // Cadena de conexión a la base de datos
        private readonly string cadenaConexion = "Data Source=LAPTOP-H9IIDHRA\\SQLEXPRESS;Initial Catalog=RRHH2;Integrated Security=True";

        // Abre la conexión
        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open(); // Intenta abrir la conexión
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception($"Error al abrir la conexión: {ex.Message}");
            }
            return conexion;
        }

        // Cierra la conexión si está abierta
        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close(); // Cierra la conexión
            }
        }

        // Ejecuta una consulta SELECT y retorna los resultados como DataTable
        public DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection conexion = AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agrega los parámetros si existen
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    // Ejecuta la consulta y llena el DataTable con los resultados
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt; // Retorna el DataTable con los datos
                    }
                }
            }
        }

        // Registra una actividad en la tabla de historial
        public void RegistrarActividad(int usuarioID, string accion)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    string query = "INSERT INTO HistorialActividades (UsuarioID, Accion) VALUES (@UsuarioID, @Accion)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Agrega los parámetros necesarios
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                        cmd.Parameters.AddWithValue("@Accion", accion);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Imprime un mensaje según el resultado
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Actividad registrada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se registró la actividad.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores al registrar la actividad
                Console.WriteLine($"Error al registrar la actividad: {ex.Message}");
            }
        }
    }
}


//ultima versión 