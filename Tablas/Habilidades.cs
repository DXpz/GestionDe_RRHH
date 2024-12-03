using GestionDe_RRHH.ConexionABase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_RRHH.Tablas
{
    public class Habilidad
    {
        //Propiedades
        public int HabilidadID { get; set; }
        public int ColaboradorID { get; set; }
        public string HabilidadNombre { get; set; }

        /// <summary>
        /// Método para agregar una nueva habilidad a la base de datos
        /// </summary>
        public void AgregarHabilidad()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "INSERT INTO Habilidades (ColaboradorID, Habilidad) VALUES (@ColaboradorID, @Habilidad)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                cmd.Parameters.AddWithValue("@Habilidad", HabilidadNombre);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar una habilidad existente en la base
        /// </summary>
        public void ActualizarHabilidad()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE Habilidades SET Habilidad = @Habilidad WHERE HabilidadID = @HabilidadID";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@HabilidadID", HabilidadID);
                cmd.Parameters.AddWithValue("@Habilidad", HabilidadNombre);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para eliminar una habilidad de la base de datos
        /// </summary>
        public void EliminarHabilidad()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "DELETE FROM Habilidades WHERE HabilidadID = @HabilidadID";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@HabilidadID", HabilidadID);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método estático para obtener las habilidades de un colaborador.
        /// </summary>
        /// <param name="colaboradorID">El ID del colaborador para el que se desean obtener sus habilidades</param>
        /// <returns>Un DataTable con las habilidades</returns>
        public static DataTable ObtenerHabilidades(int colaboradorID)
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "SELECT HabilidadID, Habilidad FROM Habilidades WHERE ColaboradorID = @ColaboradorID";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ColaboradorID", colaboradorID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
