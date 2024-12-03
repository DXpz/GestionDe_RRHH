using GestionDe_RRHH.ConexionABase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GestionDe_RRHH
{
    /// <summary>
    /// Formulario para realizar búsquedas de colaboradores
    /// Permite buscar por diferentes criterios y visualizar los resultados
    /// </summary>
    public partial class BusquedaForm : Form
    {
        
        // Cadena de conexión a la base de datos.
        private string connectionString = "Data Source=LAPTOP-I6TST00L\\SQLEXPRESS;Initial Catalog=RRHH2;Integrated Security=True";

        public BusquedaForm()
        {
            InitializeComponent();
            CargarCriterios();
        }

        /// <summary>
        /// Carga los criterios de búsqueda en el ComboBox
        /// </summary>
        private void CargarCriterios()
        {
            cmbCriterio.Items.Clear();
            cmbCriterio.Items.AddRange(new object[]
            {
                "NombreCompleto",   
                "Departamento",     
                "Habilidad",        
                "Competencia",     
                "Email",           
                "Telefono",         
                "FechaIngreso",    
                "EstadoActivo" 
            });
            cmbCriterio.SelectedIndex = 0; // Selección predeterminada
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento del botón Buscar
        /// Realiza la búsqueda en la base de datos según el criterio y el valor ingresado
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new ConexionBD().AbrirConexion())
            {
                // Consulta SQL base
                string query = @"
                    SELECT c.ColaboradorID AS ID, 
                           c.NombreCompleto AS Nombre, 
                           c.Departamento, 
                           c.Email, 
                           c.Telefono, 
                           c.FechaIngreso, 
                           c.EstadoActivo, 
                           c.Foto
                    FROM Colaboradores c";

                // Modificar consulta según el criterio seleccionado
                if (criterio == "Habilidad")
                {
                    query += @"
                        INNER JOIN Habilidades h ON c.ColaboradorID = h.ColaboradorID
                        WHERE h.Habilidad LIKE @Valor";
                }
                else if (criterio == "Competencia")
                {
                    query += @"
                        INNER JOIN Competencias comp ON c.ColaboradorID = comp.ColaboradorID
                        WHERE comp.Competencia LIKE @Valor";
                }
                else
                {
                    query += @"
                        WHERE c." + criterio + " LIKE @Valor";
                }

                // Ejecutar la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Valor", "%" + valor + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar resultados en el DataGridView
                dgvResultados.DataSource = dt;

                // Ocultar columna de fotos si existe
                if (dgvResultados.Columns.Contains("Foto"))
                {
                    dgvResultados.Columns["Foto"].Visible = false;
                }
            }
        }

        /// <summary>
        /// Evento para actualizar la imagen del PictureBox según la fila seleccionada
        /// </summary>
        private void dgvResultados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResultados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvResultados.SelectedRows[0];

                // Verificar si la celda contiene una imagen
                if (filaSeleccionada.Cells["Foto"].Value != DBNull.Value)
                {
                    byte[] fotoBytes = (byte[])filaSeleccionada.Cells["Foto"].Value;
                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                    {
                        pbFoto.Image = Image.FromStream(ms); // Cargar imagen en el PictureBox
                    }
                }
                else
                {
                    pbFoto.Image = null; // Limpiar el PictureBox si no hay foto
                }
            }
        }
    }
}
