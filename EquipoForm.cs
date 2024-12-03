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
    /// Formulario para mostrar información del equipo
    /// </summary>
    public partial class EquipoForm : Form
    {
        /// <summary>
        /// Constructor del formulario EquipoForm
        /// Inicializa el formulario y carga la información del equipo
        /// </summary>
        public EquipoForm()
        {
            InitializeComponent();
            CargarEquipo();
        }

        /// <summary>
        /// Carga la información de los integrantes del equipo en un DataTable y lo asigna al DataGridView
        /// </summary>
        private void CargarEquipo()
        {
            // Crear una tabla en memoria para mostrar los datos
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Completo", typeof(string)); // Columna para nombres+
            dt.Columns.Add("Carnet", typeof(string));          // Columna para carnets

            // Agregar filas
            dt.Rows.Add("Carles Geovanny Rivera Marroquín", "RM101723");
            dt.Rows.Add("Héctor Antonio Mejía Ascencio", "MA100423");
            dt.Rows.Add("Atilio Gustavo Morataya Serrano", "MS101122");
            dt.Rows.Add("Fátima Sarahí Coreas Hernandez ", "Ch100723");

            // Asignar la tabla al DataGridView
            dgvEquipo.DataSource = dt;
        }

        /// <summary>
        /// Evento del botón Volver
        /// Cierra el formulario actual y retorna al formulario anterior
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
