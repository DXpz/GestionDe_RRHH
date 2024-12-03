using GestionDe_RRHH.ConexionABase;
using System;
using System.Data.SqlClient;
using System.Data;

namespace GestionDe_RRHH.Tablas
{
    /// <summary>
    /// Representa un colaborador con sus datos personales
    /// </summary>
    public class Colaborador
    {
        //propiedades
        public int ColaboradorID { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Objetivo { get; set; }
        public byte[] Foto { get; set; }
        public bool EstadoActivo { get; set; } = true;

        /// <summary>
        /// Agrega un nuevo colaborador a la base de datos
        /// </summary>
        public void AgregarColaborador()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "INSERT INTO Colaboradores (NombreCompleto, Telefono, Email, Departamento, Objetivo, Foto, EstadoActivo) " +
                               "VALUES (@NombreCompleto, @Telefono, @Email, @Departamento, @Objetivo, @Foto, @EstadoActivo)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Departamento", Departamento);
                comando.Parameters.AddWithValue("@Objetivo", Objetivo ?? (object)DBNull.Value);
                comando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = Foto ?? (object)DBNull.Value;
                comando.Parameters.AddWithValue("@EstadoActivo", EstadoActivo);
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza la información de un colaborador existente en la base de datos
        /// </summary>
        public void ActualizarColaborador()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE Colaboradores SET NombreCompleto = @NombreCompleto, Telefono = @Telefono, " +
                               "Email = @Email, Departamento = @Departamento, Objetivo = @Objetivo, Foto = @Foto " +
                               "WHERE ColaboradorID = @ColaboradorID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Departamento", Departamento);
                comando.Parameters.AddWithValue("@Objetivo", Objetivo ?? (object)DBNull.Value);
                comando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = Foto ?? (object)DBNull.Value;
                comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Marca a un colaborador como inactivo en la base de datos
        /// </summary>
        public void EliminarColaborador()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "UPDATE Colaboradores SET EstadoActivo = 0 WHERE ColaboradorID = @ColaboradorID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ColaboradorID", ColaboradorID);
                comando.ExecuteNonQuery();
            }
        }
    }
}
