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
    /// Formulario principal del menú de la aplicación
    /// Gestiona las acciones de acuerdo al rol del usuario
    /// </summary>
    public partial class MainMenuForm : Form
    {
        private string RolUsuario;

        /// <summary>
        /// Constructor principal con el rol como parámetro
        /// </summary>
        /// <param name="rolUsuario">Rol del usuario (Admin o Operador)</param>
        public MainMenuForm(string rolUsuario)
        {
            InitializeComponent();
            RolUsuario = rolUsuario; // Asigna el rol recibido
            AplicarRestriccionesPorRol(); 
        }

        /// <summary>
        /// Constructor sin parámetros (para compatibilidad)
        /// Asigna un rol predeterminado en caso de no recibir uno
        /// </summary>
        public MainMenuForm()
        {
            InitializeComponent();
            RolUsuario = "Operador"; // Rol predeterminado si no se especifica
            AplicarRestriccionesPorRol();
        }

        /// <summary>
        /// Aplica las restricciones de acceso según el rol del usuario
        /// </summary>
        private void AplicarRestriccionesPorRol()
        {
            if (RolUsuario == "Operador")
            {
                // Deshabilitar botones para operadores
                btnGestionColaboradores.Enabled = false;
                btnHistorial.Enabled = false;
                btnAgregarUsuario.Enabled = false;
            }
            else if (RolUsuario == "Admin")
            {
                // Habilitar botones para administradores
                btnGestionColaboradores.Enabled = true;
                btnHistorial.Enabled = true;
                btnAgregarUsuario.Enabled = true;
            }
        }

        /// <summary>
        /// Evento que se activa cuando el formulario se activa
        /// Reaplica las restricciones por rol al activarse el formulario
        /// </summary>
        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            AplicarRestriccionesPorRol(); // Reaplica las restricciones
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de gestión de colaboradores
        /// Abre el formulario de gestión de colaboradores
        /// </summary>
        private void btnGestionColaboradores_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el menú principal
            using (ColaboradoresForm colaboradoresForm = new ColaboradoresForm())
            {
                colaboradoresForm.ShowDialog(); // Abre el formulario de colaboradores como modal
            }
            this.Show(); // Mostrar el menú principal después de cerrar el formulario
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de equipo
        /// Abre el formulario del equipo
        /// </summary>
        private void btnEquipo_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el menú principal
            using (EquipoForm equipoForm = new EquipoForm())
            {
                equipoForm.ShowDialog(); // Abre el formulario de equipo como modal
            }
            this.Show(); // Mostrar el menú principal después de cerrar el formulario
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de historial
        /// Abre el formulario de historial de actividades
        /// </summary>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el menú principal
            using (HistorialForm historialForm = new HistorialForm())
            {
                historialForm.ShowDialog(); // Abre el formulario de historial como modal
            }
            this.Show(); // Mostrar el menú principal después de cerrar el formulario
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de búsqueda
        /// Abre el formulario de búsqueda de registros
        /// </summary>
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el menú principal
            using (BusquedaForm busquedaForm = new BusquedaForm())
            {
                busquedaForm.ShowDialog(); // Abre el formulario de búsqueda como modal
            }
            this.Show(); // Mostrar el menú principal nuevamente al cerrar el formulario de búsqueda
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de agregar usuario
        /// Solo los administradores tienen permiso para agregar usuarios
        /// </summary>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "Admin")
            {
                using (RegistroUsuarioForm registroUsuarioForm = new RegistroUsuarioForm())
                {
                    registroUsuarioForm.ShowDialog(); // Abre el formulario de registro de usuario como modal
                }
            }
            else
            {
                // Mostrar mensaje de acceso denegado si no es administrador
                MessageBox.Show("Acceso denegado. Solo los administradores pueden agregar usuarios.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón de salir
        /// Cierra la aplicación si se confirma la acción
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
    }
}
