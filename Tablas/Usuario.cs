using GestionDe_RRHH.ConexionABase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_RRHH.Tablas
{
    public class Usuario
    {
        //Propiedades
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        /// <summary>
        /// Método privado para incriptar contraseñas utilizando SHA256
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns>Una cadena representa la contraseña en formato hexadecimal</returns>
        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create()) // Crear una instancia de SHA256
            {
                // Convertir la contraseña en un arreglo de bytes y calcular su hash
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

                // Construir el hash como un string en formato hexadecimal
                StringBuilder resultado = new StringBuilder();
                foreach (byte b in bytes)
                {
                    resultado.Append(b.ToString("x2"));
                }

                // Devolver la contraseña encriptada
                return resultado.ToString();
            }
        }

        /// <summary>
        /// Método para validar las credenciales del usuario desde la base de datos
        /// </summary>
        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            // Abrir la conexión 
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                // Consulta SQL para verificar si el usuario y la contraseña existen
                string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", EncriptarContraseña(contraseña));

                // Ejecutar el comando y verificar si se encontró al menos un resultado
                return (int)comando.ExecuteScalar() > 0;
            }
        }

        /// <summary>
        /// Método para obtener el rol de un usuario
        /// </summary>
        public string ObtenerRol(string nombreUsuario)
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                // Consulta SQL para obtener el rol del usuario
                string query = "SELECT Rol FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                // Ejecutar el comando y devolver el rol
                return comando.ExecuteScalar()?.ToString();
            }
        }

        /// Método para obtener el ID de un usuario en la base de datos
        public int ObtenerUsuarioID(string nombreUsuario)
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                // Consulta SQL para obtener el ID del usuario
                string query = "SELECT UsuarioID FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                // Ejecutar el comando y verificar si se obtuvo un resultado
                object resultado = comando.ExecuteScalar();
                if (resultado != null)
                {
                    // Convertir el resultado a un entero y devolverlo
                    return Convert.ToInt32(resultado);
                }
                else
                {
                    // una excepción si el usuario no existe
                    throw new Exception("Usuario no encontrado.");
                }
            }
        }

        /// <summary>
        /// Método para registrar un nuevo usuario en la base de datos
        /// </summary>

        public void RegistrarUsuario(string nombreUsuario, string contraseña, string rol)
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                // Consulta SQL para insertar un nuevo usuario
                string query = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol) VALUES (@NombreUsuario, @Contraseña, @Rol)";

                // Crear un comando SQL y asignar parámetros
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", EncriptarContraseña(contraseña));
                comando.Parameters.AddWithValue("@Rol", rol);

                // Ejecutar el comando para registrar al usuario
                comando.ExecuteNonQuery();
            }
        }
    }
}

