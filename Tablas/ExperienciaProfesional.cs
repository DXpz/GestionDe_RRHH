using GestionDe_RRHH.ConexionABase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_RRHH.Tablas
{
    public class ExperienciaProfesional
    {
        //Propiedades
        public int ExperienciaID { get; set; }
        public int ColaboradorID { get; set; }
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public int AñoInicio { get; set; }
        public int AñoFin { get; set; }

        /// <summary>
        /// Método para agregar una nueva experiencia profesional a la base de datos
        /// </summary>
        public void AgregarExperiencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "INSERT INTO ExperienciaProfesional (ColaboradorID, Empresa, Puesto, AñoInicio, AñoFin) " +
                               "VALUES (@ColaboradorID, @Empresa, @Puesto, @AñoInicio, @AñoFin)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                comando.Parameters.AddWithValue("@Empresa", Empresa);
                comando.Parameters.AddWithValue("@Puesto", Puesto);
                comando.Parameters.AddWithValue("@AñoInicio", AñoInicio);
                comando.Parameters.AddWithValue("@AñoFin", AñoFin);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar una experiencia profesional existente
        /// </summary>
        public void ActualizarExperiencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE ExperienciaProfesional SET Empresa = @Empresa, Puesto = @Puesto, " +
                               "AñoInicio = @AñoInicio, AñoFin = @AñoFin WHERE ExperienciaID = @ExperienciaID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ExperienciaID", ExperienciaID);
                comando.Parameters.AddWithValue("@Empresa", Empresa);
                comando.Parameters.AddWithValue("@Puesto", Puesto);
                comando.Parameters.AddWithValue("@AñoInicio", AñoInicio);
                comando.Parameters.AddWithValue("@AñoFin", AñoFin);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para eliminar una experiencia profesional de la base de datos
        /// </summary>
        public void EliminarExperiencia()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "DELETE FROM ExperienciaProfesional WHERE ExperienciaID = @ExperienciaID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ExperienciaID", ExperienciaID);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para obtener todas las experiencias profesionales de un colaborador
        /// </summary>
        /// <param name="colaboradorID">El ID del colaborador para obtener sus experiencias profesionales</param>
        /// <returns>Una lista "ExperienciaProfesional" que representan las experiencias de un colaborador</returns>
        public static List<ExperienciaProfesional> ObtenerExperiencias(int colaboradorID)
        {
            List<ExperienciaProfesional> listaExperiencias = new List<ExperienciaProfesional>();

            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "SELECT ExperienciaID, ColaboradorID, Empresa, Puesto, AñoInicio, AñoFin " +
                               "FROM ExperienciaProfesional WHERE ColaboradorID = @ColaboradorID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", colaboradorID);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaExperiencias.Add(new ExperienciaProfesional
                    {
                        ExperienciaID = Convert.ToInt32(reader["ExperienciaID"]),
                        ColaboradorID = Convert.ToInt32(reader["ColaboradorID"]),
                        Empresa = reader["Empresa"].ToString(),
                        Puesto = reader["Puesto"].ToString(),
                        AñoInicio = Convert.ToInt32(reader["AñoInicio"]),
                        AñoFin = Convert.ToInt32(reader["AñoFin"])
                    });
                }
            }

            return listaExperiencias;
        }
    }
}
