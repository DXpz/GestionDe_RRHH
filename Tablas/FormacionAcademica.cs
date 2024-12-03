using GestionDe_RRHH.ConexionABase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_RRHH.Tablas
{
    public class FormacionAcademica
    {
        //Propiedades
        public int FormacionID { get; set; }
        public int ColaboradorID { get; set; }
        public string Institucion { get; set; }
        public string Titulo { get; set; }
        public int AñoInicio { get; set; }
        public int AñoFin { get; set; }

        /// <summary>
        /// Método para agregar una formación académica a la base de datos
        /// </summary>
        public void AgregarFormacion()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "INSERT INTO FormacionAcademica (ColaboradorID, Institucion, Titulo, AñoInicio, AñoFin) " +
                               "VALUES (@ColaboradorID, @Institucion, @Titulo, @AñoInicio, @AñoFin)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                comando.Parameters.AddWithValue("@Institucion", Institucion);
                comando.Parameters.AddWithValue("@Titulo", Titulo);
                comando.Parameters.AddWithValue("@AñoInicio", AñoInicio);
                comando.Parameters.AddWithValue("@AñoFin", AñoFin);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar una formación académica existente
        /// </summary>
        public void ActualizarFormacion()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE FormacionAcademica SET Institucion = @Institucion, Titulo = @Titulo, " +
                               "AñoInicio = @AñoInicio, AñoFin = @AñoFin WHERE FormacionID = @FormacionID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@FormacionID", FormacionID);
                comando.Parameters.AddWithValue("@Institucion", Institucion);
                comando.Parameters.AddWithValue("@Titulo", Titulo);
                comando.Parameters.AddWithValue("@AñoInicio", AñoInicio);
                comando.Parameters.AddWithValue("@AñoFin", AñoFin);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para eliminar una formación académica de la base de datos
        /// </summary>
        public void EliminarFormacion()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "DELETE FROM FormacionAcademica WHERE FormacionID = @FormacionID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@FormacionID", FormacionID);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método estático para obtener todas las formaciones académicas de un colaborador
        /// </summary>
        /// <param name="colaboradorID">El ID del colaborador para obtener sus formaciones académicas</param>
        /// <returns>Una lista de objetos "FormacionAcademica" que representan las formaciones del colaborador</returns>
        public static List<FormacionAcademica> ObtenerFormaciones(int colaboradorID)
        {
            List<FormacionAcademica> listaFormaciones = new List<FormacionAcademica>();

            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "SELECT FormacionID, ColaboradorID, Institucion, Titulo, AñoInicio, AñoFin " +
                               "FROM FormacionAcademica WHERE ColaboradorID = @ColaboradorID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", colaboradorID);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaFormaciones.Add(new FormacionAcademica
                    {
                        FormacionID = Convert.ToInt32(reader["FormacionID"]),
                        ColaboradorID = Convert.ToInt32(reader["ColaboradorID"]),
                        Institucion = reader["Institucion"].ToString(),
                        Titulo = reader["Titulo"].ToString(),
                        AñoInicio = Convert.ToInt32(reader["AñoInicio"]),
                        AñoFin = Convert.ToInt32(reader["AñoFin"])
                    });
                }
            }

            return listaFormaciones;
        }
    }
}
