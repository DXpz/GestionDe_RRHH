using GestionDe_RRHH.ConexionABase;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionDe_RRHH
{
    /// <summary>
    /// Formulario para mostrar y gestionar el historial de actividades.
    /// Permite visualizar el historial en un DataGridView y exportarlo a "PDF".
    /// </summary>
    public partial class HistorialForm : Form
    {
        /// <summary>
        /// Constructor del formulario HistorialForm.
        /// Inicializa el formulario y carga el historial de actividades.
        /// </summary>
        public HistorialForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Carga el historial de actividades.
        /// </summary>
        private void HistorialForm_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        /// <summary>
        /// Carga el historial de actividades desde la base de datos y lo muestra en el DataGridView.
        /// </summary>
        private void CargarHistorial()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string query = @"
                    SELECT h.ActividadID AS ID, 
                           u.NombreUsuario AS Usuario, 
                           h.Accion AS Acción, 
                           h.FechaActividad AS Fecha
                    FROM HistorialActividades h
                    INNER JOIN Usuarios u ON h.UsuarioID = u.UsuarioID
                    ORDER BY h.FechaActividad DESC";

                DataTable historial = conexion.EjecutarConsulta(query);
                dgvHistorial.DataSource = historial;

                // Configuración del DataGridView
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHistorial.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exporta el historial mostrado en el DataGridView a un archivo PDF.
        /// </summary>
        private void ExportarHistorialAPdf()
        {
            try
            {
                // Verificar si hay datos en el DataGridView
                if (dgvHistorial.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos en el historial para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar cuadro de diálogo para guardar
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivos PDF (*.pdf)|*.pdf",
                    Title = "Guardar Historial de Actividades",
                    FileName = "HistorialActividades.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoPdf = saveFileDialog.FileName;

                    // Obtener datos del DataGridView
                    DataTable historial = ObtenerDatosDesdeDataGridView();

                    if (historial == null || historial.Rows.Count == 0)
                    {
                        MessageBox.Show("El historial no contiene datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Generar el PDF
                    using (PdfWriter writer = new PdfWriter(archivoPdf))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        // Título del PDF
                        document.Add(new Paragraph("Historial de Actividades")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(16));

                        // Crear tabla con columnas dinámicas
                        Table table = new Table(UnitValue.CreatePercentArray(historial.Columns.Count));
                        table.SetWidth(UnitValue.CreatePercentValue(100));

                        // Encabezados
                        foreach (DataColumn column in historial.Columns)
                        {
                            table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName).SetFontSize(12)));
                        }

                        // Filas
                        foreach (DataRow row in historial.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.ToString())));
                            }
                        }

                        document.Add(table);
                    }

     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convierte los datos del DataGridView en un DataTable.
        /// </summary>
        /// <returns>Un DataTable con los datos del DataGridView.</returns>
        private DataTable ObtenerDatosDesdeDataGridView()
        {
            DataTable dataTable = new DataTable();

            // Verificar que el DataGridView tenga columnas y filas
            if (dgvHistorial.Columns.Count > 0 && dgvHistorial.Rows.Count > 0)
            {
                // Agregar las columnas al DataTable
                foreach (DataGridViewColumn column in dgvHistorial.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                // Agregar las filas al DataTable
                foreach (DataGridViewRow row in dgvHistorial.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < dgvHistorial.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value ?? "";
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }

            return dataTable;
        }

        // Evento del botón Volver
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento del botón Generar PDF.
        /// Llama al método para exportar el historial a PDF.
        /// </summary>
        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {
            ExportarHistorialAPdf();
        }
    }
}