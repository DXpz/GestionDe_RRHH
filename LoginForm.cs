using GestionDe_RRHH.ConexionABase;
using GestionDe_RRHH.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDe_RRHH
{
    /// <summary>
    /// Formulario para el inicio de sesión
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que al hacer clic en el botón de iniciar sesión
        /// Valida las credenciales del usuario e inicia sesión si son correctas
        /// </summary>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            Usuario usuario = new Usuario();

            // Validar usuario con el nombre de usuario y la contraseña proporcionados
            if (usuario.ValidarUsuario(nombreUsuario, contraseña))
            {
                // Obtener el rol y el ID del usuario
                string rol = usuario.ObtenerRol(nombreUsuario);
                int usuarioID = usuario.ObtenerUsuarioID(nombreUsuario);

                // Registrar actividad del usuario
                ConexionBD conexion = new ConexionBD();
                conexion.RegistrarActividad(usuarioID, "Inicio de sesión exitoso");

                // Pasar el rol al formulario principal
                MainMenuForm menu = new MainMenuForm(rol);
                menu.Show();
                this.Hide();

                MessageBox.Show($"Bienvenido, {rol}.", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de salir
        /// Cierra la aplicación
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        /// <summary>
        /// Evento que abre el formulario de registro de usuario
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            using (RegistroUsuarioForm registroUsuarioForm = new RegistroUsuarioForm())
            {
                registroUsuarioForm.ShowDialog(); // Abre el formulario de registro de usuario como modal
            }
        }

        /// <summary>
        /// Evento para alternar la visibilidad de la contraseña
        /// Cambia la imagen del ojo dependiendo del estado de visibilidad de la contraseña
        /// </summary>
        private void picEye_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                // Mostrar la contraseña
                txtContraseña.UseSystemPasswordChar = false;
                picEye.Image = Properties.Resources.ojo_abierto; // Cambiar a imagen de ojo abierto
            }
            else
            {
                // Ocultar la contraseña
                txtContraseña.UseSystemPasswordChar = true;
                picEye.Image = Properties.Resources.ojo_cerrado; // Cambiar a imagen de ojo cerrado
            }
        }

        /// <summary>
        /// Evento que se dispara al cargar el formulario de inicio de sesión
        /// Inicializa el estado del ícono del ojo y oculta la contraseña por defecto
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            picEye.Image = Properties.Resources.ojo_cerrado; // Iniciar con el ojo cerrado
            txtContraseña.UseSystemPasswordChar = true; // Contraseña oculta por defecto
        }
    }
}
