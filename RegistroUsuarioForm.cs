using GestionDe_RRHH.Tablas;
using System;
using System.Windows.Forms;

namespace GestionDe_RRHH
{
    /// <summary>
    /// Formulario para registrar nuevos usuarios en el sistema
    /// Permite ingresar el nombre, contraseña y rol del usuario
    /// </summary>
    public partial class RegistroUsuarioForm : Form
    {
        /// <summary>
        /// Constructor del formulario RegistroUsuarioForm
        /// Inicializa los componentes del formulario
        /// </summary>
        public RegistroUsuarioForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del botón Registrar
        /// Valida los datos ingresados por el usuario y registra un nuevo usuario
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene y valida los datos ingresados
                string nombreUsuario = txtNombreUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();
                string rol = cmbRol.SelectedItem?.ToString();

                // Verificar si algún campo está vacío
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo usuario y registrarlo en el sistema
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.RegistrarUsuario(nombreUsuario, contraseña, rol);

                // Confirmar registro
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Cancelar
        // Cierra el formulario sin realizar cambios
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
    }
}
