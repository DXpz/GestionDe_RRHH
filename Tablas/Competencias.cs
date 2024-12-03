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
    public class Competencia
    {
        //Propiedades
        public int CompetenciaID { get; set; }
        public int ColaboradorID { get; set; }
        public string CompetenciaNombre { get; set; }
        public string Dominio { get; set; }

        /// <summary>
        /// Método para agregar una nueva competencia a la base de datos
        /// </summary>
        public void AgregarCompetencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "INSERT INTO Competencias (ColaboradorID, Competencia, Dominio) VALUES (@ColaboradorID, @Competencia, @Dominio)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                comando.Parameters.AddWithValue("@Competencia", CompetenciaNombre);
                comando.Parameters.AddWithValue("@Dominio", Dominio);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar una competencia existente en la base
        /// </summary>
        public void ActualizarCompetencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE Competencias SET Competencia = @Competencia, Dominio = @Dominio WHERE CompetenciaID = @CompetenciaID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@CompetenciaID", CompetenciaID);
                comando.Parameters.AddWithValue("@Competencia", CompetenciaNombre);
                comando.Parameters.AddWithValue("@Dominio", Dominio);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para eliminar una competencia de la base de datos
        /// </summary>
        public void EliminarCompetencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "DELETE FROM Competencias WHERE CompetenciaID = @CompetenciaID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@CompetenciaID", CompetenciaID);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método estático para obtener todas las competencias de un colaborador.
        /// </summary>
        /// <param name="colaboradorID">El ID del colaborador para obtener sus competencias</param>
        /// <returns>Un DataTable con las competencias del colaborador</returns>
        public static DataTable ObtenerCompetencias(int colaboradorID)
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "SELECT CompetenciaID, Competencia, Dominio FROM Competencias WHERE ColaboradorID = @ColaboradorID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", colaboradorID);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }
    }
}
