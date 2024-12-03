using GestionDe_RRHH.ConexionABase;
using GestionDe_RRHH.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDe_RRHH
{
    /// <summary>
    /// Formulario para la gestión de colaboradores
    /// Permite agregar, actualizar, eliminar, buscar colaboradores y manejar su información
    /// </summary>
    public partial class ColaboradoresForm : Form
    {
        // Constructor
        public ColaboradoresForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ColaboradoresForm_Load);
            dgvColaboradores.SelectionChanged += new EventHandler(dgvColaboradores_SelectionChanged);
        }

        // Evento que se ejecuta al cargar el formulario
        private void ColaboradoresForm_Load(object sender, EventArgs e)
        {
            CargarColaboradores();
        }


        /// <summary>
        /// Carga los colaboradores desde la base de datos y los muestra en el DataGridView
        /// </summary>
        private void CargarColaboradores()
        {
            using (SqlConnection conexion = new ConexionBD().AbrirConexion())
            {
                string query = "SELECT ColaboradorID, NombreCompleto, Telefono, Email, Departamento, EstadoActivo, Objetivo FROM Colaboradores";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvColaboradores.DataSource = dt;
            }
        }


        /// <summary>
        /// Botón Agrega 
        /// Agrega un nuevo colaborador con la información proporcionada en el formulario
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Colaborador colaborador = new Colaborador
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Departamento = txtDepartamento.Text.Trim(),
                    Objetivo = txtObjetivo.Text.Trim(),
                    EstadoActivo = true,
                };

                // Convierte la imagen en el PictureBox a un arreglo de bytes
                if (pictureBoxFoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxFoto.Image.Save(ms, pictureBoxFoto.Image.RawFormat);
                        colaborador.Foto = ms.ToArray();
                    }
                }

                colaborador.AgregarColaborador();
                MessageBox.Show("Colaborador agregado exitosamente.");
                CargarColaboradores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        /// <summary>
        /// Evento del botón Actualizar 
        /// Actualiza los datos del colaborador seleccionado
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    Colaborador colaborador = new Colaborador
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value),
                        NombreCompleto = txtNombreCompleto.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Departamento = txtDepartamento.Text.Trim(),
                        Objetivo = txtObjetivo.Text.Trim(),
                    };

                    // Convierte la imagen en el PictureBox a un arreglo de bytes
                    if (pictureBoxFoto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxFoto.Image.Save(ms, pictureBoxFoto.Image.RawFormat);
                            colaborador.Foto = ms.ToArray();
                        }
                    }

                    colaborador.ActualizarColaborador();
                    MessageBox.Show("Colaborador actualizado exitosamente.");
                    CargarColaboradores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un colaborador para actualizar.");
            }
        }



        /// <summary>
        /// Marca un colaborador como inactivo en la base de datos
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    Colaborador colaborador = new Colaborador
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value)
                    };

                    colaborador.EliminarColaborador();
                    MessageBox.Show("Colaborador marcado como inactivo.");
                    CargarColaboradores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un colaborador para eliminar.");
            }
        }

        /// <summary>
        /// Evento del botón Seleccionar - Foto 
        /// Permite cargar una foto desde un archivo al PictureBox
        /// </summary>
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar una foto";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen seleccionada en el PictureBox
                        this.pictureBoxFoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                        this.pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        /// <summary>
        /// Evento del botón Buscar 
        /// Busca colaboradores que coincidan con el criterio de busqueda seleccionado
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtNombreCompleto.Text.Trim();
            if (!string.IsNullOrEmpty(criterio))
            {
                using (SqlConnection conexion = new ConexionBD().AbrirConexion())
                {
                    string query = "SELECT ColaboradorID, NombreCompleto, Telefono, Email, Departamento, EstadoActivo FROM Colaboradores WHERE NombreCompleto LIKE @Criterio + '%'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Criterio", criterio);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvColaboradores.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un criterio de búsqueda.");
            }
        }

        // Método para cargar formación académica
        private void CargarFormaciones()
        {
            // Verifica si hay un colaborador seleccionado
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                int colaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value);

                using (SqlConnection conexion = new ConexionBD().AbrirConexion())
                {
                    string query = "SELECT Institucion, Titulo, AñoInicio, AñoFin FROM FormacionAcademica WHERE ColaboradorID = @ColaboradorID";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ColaboradorID", colaboradorID);

                    // Llena un DataTable con los datos obtenidos y lo asigna al DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFormacionAcademica.DataSource = dt;
                }
            }
            else
            {
                // Limpia el DataGridView si no hay colaborador seleccionado
                dgvFormacionAcademica.DataSource = null;
            }
        }

        // Método para agregar una nueva formación académica
        private void btnAgregarFormacion_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    // Crea una nueva instancia de formación académica con los datos ingresados
                    FormacionAcademica formacion = new FormacionAcademica
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value),
                        Institucion = txtInstitucion.Text.Trim(),
                        Titulo = txtTitulo.Text.Trim(),
                        AñoInicio = (int)numAñoInicio.Value,
                        AñoFin = (int)numAñoFin.Value
                    };

                    formacion.AgregarFormacion();
                    MessageBox.Show("Formación académica agregada exitosamente.");
                    // Recarga las formaciones académicas para reflejar el cambio
                    CargarFormaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la formación académica: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un colaborador antes de agregar formación académica.");
            }
        }

        // Método para actualizar una formación académica existente
        private void btnActualizarFormacion_Click(object sender, EventArgs e)
        {
            if (dgvFormacionAcademica.SelectedRows.Count > 0)
            {
                FormacionAcademica formacion = new FormacionAcademica
                {
                    FormacionID = Convert.ToInt32(dgvFormacionAcademica.SelectedRows[0].Cells["FormacionID"].Value),
                    Institucion = txtInstitucion.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    AñoInicio = (int)numAñoInicio.Value,
                    AñoFin = (int)numAñoFin.Value
                };

                formacion.ActualizarFormacion();
                MessageBox.Show("Formación actualizada exitosamente.");
                CargarFormaciones();
            }
            else
            {
                MessageBox.Show("Seleccione una formación para actualizar.");
            }
        }

        // Método para eliminar una formación académica
        private void btnEliminarFormacion_Click(object sender, EventArgs e)
        {
            if (dgvFormacionAcademica.SelectedRows.Count > 0)
            {
                FormacionAcademica formacion = new FormacionAcademica
                {
                    FormacionID = Convert.ToInt32(dgvFormacionAcademica.SelectedRows[0].Cells["FormacionID"].Value)
                };

                formacion.EliminarFormacion();
                MessageBox.Show("Formación eliminada exitosamente.");
                CargarFormaciones();
            }
            else
            {
                MessageBox.Show("Seleccione una formación para eliminar.");
            }
        }

        // Método para cargar experiencia profesional
        private void CargarExperiencias()
        {
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                int colaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value);

                using (SqlConnection conexion = new ConexionBD().AbrirConexion())
                {
                    string query = "SELECT Empresa, Puesto, AñoInicio, AñoFin FROM ExperienciaProfesional WHERE ColaboradorID = @ColaboradorID";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ColaboradorID", colaboradorID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvExperienciaProfesional.DataSource = dt;
                }
            }
            else
            {
                dgvExperienciaProfesional.DataSource = null;
            }
        }

        /// <summary>
        /// Agrega una nueva experiencia profesional al colaborador seleccionado
        /// </summary>
        /// <param name="sender">El objeto que invoca el evento</param>
        /// <param name="e">Los datos del evento asociados.</param>
        private void btnAgregarExperiencia_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva instancia de la clase ExperienciaProfesional con los datos proporcionados
                ExperienciaProfesional experiencia = new ExperienciaProfesional
                {
                    ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value),
                    Empresa = txtEmpresa.Text.Trim(),
                    Puesto = txtPuesto.Text.Trim(),
                    AñoInicio = (int)numAñoInicioExperiencia.Value,  
                    AñoFin = (int)numAñoFinExperiencia.Value
                };

                experiencia.AgregarExperiencia();
                MessageBox.Show("Experiencia agregada exitosamente.");
                CargarExperiencias();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error con los detalles de la excepción
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza una experiencia profesional seleccionada en el DataGridView
        /// </summary>
        private void btnActualizarExperiencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView de experiencias profesionales
            if (dgvExperienciaProfesional.SelectedRows.Count > 0)
            {
                // Crear una nueva instancia de la clase ExperienciaProfesional con los datos actualizados
                ExperienciaProfesional experiencia = new ExperienciaProfesional
                {
                    ExperienciaID = Convert.ToInt32(dgvExperienciaProfesional.SelectedRows[0].Cells["ExperienciaID"].Value),
                    Empresa = txtEmpresa.Text.Trim(),
                    Puesto = txtPuesto.Text.Trim(),
                    AñoInicio = (int)numAñoInicioExperiencia.Value,
                    AñoFin = (int)numAñoFinExperiencia.Value 
                };

                experiencia.ActualizarExperiencia();
                MessageBox.Show("Experiencia actualizada exitosamente.");
                CargarExperiencias();
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna experiencia
                MessageBox.Show("Seleccione una experiencia para actualizar.");
            }
        }

        /// <summary>
        /// Elimina una experiencia profesional seleccionada del colaborador.
        /// </summary>
        private void btnEliminarExperiencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView de experiencias profesionales
            if (dgvExperienciaProfesional.SelectedRows.Count > 0)
            {
                // Crear una nueva instancia de la clase ExperienciaProfesional con el ID de la experiencia a eliminar
                ExperienciaProfesional experiencia = new ExperienciaProfesional
                {
                    ExperienciaID = Convert.ToInt32(dgvExperienciaProfesional.SelectedRows[0].Cells["ExperienciaID"].Value)
                };


                experiencia.EliminarExperiencia();
                MessageBox.Show("Experiencia eliminada exitosamente.");
                CargarExperiencias();
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna experiencia
                MessageBox.Show("Seleccione una experiencia para eliminar.");
            }
        }

        /// <summary>
        /// Carga las habilidades asociadas al colaborador seleccionado y las muestra en el DataGridView
        /// </summary>
        private void CargarHabilidades()
        {
            // Verifica si hay un colaborador seleccionado en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                int colaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value);

                // Asigna las habilidades obtenidas al DataGridView
                dgvHabilidades.DataSource = Habilidad.ObtenerHabilidades(colaboradorID);
            }
            else
            {
                // Limpia el DataGridView si no hay ningún colaborador seleccionado
                dgvHabilidades.DataSource = null;
            }
        }

        /// <summary>
        /// Agrega una nueva habilidad al colaborador seleccionado.
        /// </summary>
        private void btnAgregarHabilidad_Click(object sender, EventArgs e)
        {
            // Verifica si hay un colaborador seleccionado
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de la clase Habilidad con los datos proporcionados
                    Habilidad habilidad = new Habilidad
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value),
                        HabilidadNombre = txtHabilidad.Text.Trim() 
                    };

                    // Agregar la habilidad al sistema
                    habilidad.AgregarHabilidad();
                    MessageBox.Show("Habilidad agregada exitosamente.");
                    CargarHabilidades();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al agregar habilidad: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje si no hay colaborador seleccionado
                MessageBox.Show("Seleccione un colaborador antes de agregar una habilidad.");
            }
        }

        /// <summary>
        /// Actualiza la información de una habilidad seleccionada en el DataGridView
        /// </summary>
        private void btnActualizarHabilidad_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView de habilidades
            if (dgvHabilidades.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de la clase Habilidad con los datos actualizados
                    Habilidad habilidad = new Habilidad
                    {
                        HabilidadID = Convert.ToInt32(dgvHabilidades.SelectedRows[0].Cells["HabilidadID"].Value), 
                        HabilidadNombre = txtHabilidad.Text.Trim() 
                    };

                    // Llamar al método para actualizar la habilidad en el sistema
                    habilidad.ActualizarHabilidad();

                    MessageBox.Show("Habilidad actualizada exitosamente.");
                    CargarHabilidades();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al actualizar habilidad: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna habilidad
                MessageBox.Show("Seleccione una habilidad para actualizar.");
            }
        }

        /// <summary>
        /// Elimina una habilidad seleccionada en el DataGridView del sistema.
        /// </summary>
        private void btnEliminarHabilidad_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView de habilidades
            if (dgvHabilidades.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de la clase Habilidad con el ID de la habilidad a eliminar
                    Habilidad habilidad = new Habilidad
                    {
                        HabilidadID = Convert.ToInt32(dgvHabilidades.SelectedRows[0].Cells["HabilidadID"].Value) 
                    };

                    // Llamar al método para eliminar la habilidad del sistema
                    habilidad.EliminarHabilidad();
                    MessageBox.Show("Habilidad eliminada exitosamente.");
                    CargarHabilidades();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al eliminar habilidad: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna habilidad
                MessageBox.Show("Seleccione una habilidad para eliminar.");
            }
        }

        /// <summary>
        /// Carga las competencias asociadas al colaborador seleccionado en el DataGridView
        /// </summary>
        private void CargarCompetencias()
        {
            // Verifica si hay un colaborador seleccionado en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                // Obtiene el ID del colaborador seleccionado
                int colaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value);

                // Establece las competencias obtenidas como la fuente de datos
                dgvCompetencias.DataSource = Competencia.ObtenerCompetencias(colaboradorID);
            }
        }

        /// <summary>
        /// Agrega una nueva competencia al colaborador seleccionado.
        /// </summary>
        private void btnAgregarCompetencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay un colaborador seleccionado en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Competencia con los datos ingresados
                    Competencia competencia = new Competencia
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value),
                        CompetenciaNombre = txtCompetencia.Text.Trim(),
                        Dominio = cmbDominio.SelectedItem.ToString() 
                    };

                    competencia.AgregarCompetencia();
                    MessageBox.Show("Competencia agregada exitosamente.");
                    CargarCompetencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al agregar la competencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó un colaborador
                MessageBox.Show("Seleccione un colaborador antes de agregar una competencia.");
            }
        }

        /// <summary>
        /// Actualiza la información de una competencia seleccionada.
        /// </summary>
        private void btnActualizarCompetencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una competencia seleccionada en el DataGridView
            if (dgvCompetencias.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Competencia con los datos actualizados
                    Competencia competencia = new Competencia
                    {
                        CompetenciaID = Convert.ToInt32(dgvCompetencias.SelectedRows[0].Cells["CompetenciaID"].Value),
                        CompetenciaNombre = txtCompetencia.Text.Trim(), 
                        Dominio = cmbDominio.SelectedItem.ToString() 
                    };


                    competencia.ActualizarCompetencia();
                    MessageBox.Show("Competencia actualizada exitosamente.");
                    CargarCompetencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al actualizar la competencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó una competencia
                MessageBox.Show("Seleccione una competencia para actualizar.");
            }
        }

        /// <summary>
        /// Elimina la competencia seleccionada del sistema.
        /// </summary>
        private void btnEliminarCompetencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una competencia seleccionada en el DataGridView
            if (dgvCompetencias.SelectedRows.Count > 0)
            {
                try
                {
                    Competencia competencia = new Competencia

                    {
                        CompetenciaID = Convert.ToInt32(dgvCompetencias.SelectedRows[0].Cells["CompetenciaID"].Value) 
                    };

                    competencia.EliminarCompetencia();
                    MessageBox.Show("Competencia eliminada exitosamente.");
                    CargarCompetencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al eliminar la competencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó una competencia
                MessageBox.Show("Seleccione una competencia para eliminar.");
            }
        }


        /// <summary>
        /// Agrega una nueva referencia para el colaborador seleccionado.
        /// </summary>
        private void btnAgregarReferencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay un colaborador seleccionado en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Referencia con los datos proporcionados
                    Referencia referencia = new Referencia
                    {
                        ColaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value), 
                        TipoReferencia = cmbTipoReferencia.SelectedItem.ToString(),
                        Nombre = txtNombreReferencia.Text.Trim(),
                        Telefono = txtTelefonoReferencia.Text.Trim() 
                    };

                    // Llama al método para agregar la referencia
                    referencia.AgregarReferencia();

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Referencia agregada exitosamente.");

                    // Recarga las referencias del colaborador en el DataGridView
                    CargarReferencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al agregar la referencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó un colaborador
                MessageBox.Show("Por favor, selecciona un colaborador antes de agregar una referencia.");
            }
        }

        /// <summary>
        /// Actualiza la información de una referencia seleccionada.
        /// </summary>

        private void btnActualizarReferencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una referencia seleccionada en el DataGridView
            if (dgvReferencias.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Referencia con los datos actualizados
                    Referencia referencia = new Referencia
                    {
                        ReferenciaID = Convert.ToInt32(dgvReferencias.SelectedRows[0].Cells["ReferenciaID"].Value), 
                        TipoReferencia = cmbTipoReferencia.SelectedItem.ToString(), 
                        Nombre = txtNombreReferencia.Text.Trim(), 
                        Telefono = txtTelefonoReferencia.Text.Trim() 
                    };

                    // Llama al método para actualizar la referencia
                    referencia.ActualizarReferencia();

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Referencia actualizada exitosamente.");

                    // Recarga las referencias del colaborador en el DataGridView
                    CargarReferencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al actualizar la referencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó una referencia
                MessageBox.Show("Selecciona una referencia para actualizar.");
            }
        }

        /// <summary>
        /// Elimina la referencia seleccionada del sistema.
        /// </summary>
        private void btnEliminarReferencia_Click(object sender, EventArgs e)
        {
            // Verifica si hay una referencia seleccionada en el DataGridView
            if (dgvReferencias.SelectedRows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Referencia con el ID de la referencia a eliminar
                    Referencia referencia = new Referencia
                    {
                        ReferenciaID = Convert.ToInt32(dgvReferencias.SelectedRows[0].Cells["ReferenciaID"].Value)
                    };

                    // Llama al método para eliminar la referencia
                    referencia.EliminarReferencia();

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Referencia eliminada exitosamente.");

                    // Recarga las referencias del colaborador en el DataGridView
                    CargarReferencias();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error con los detalles de la excepción
                    MessageBox.Show("Error al eliminar la referencia: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no se seleccionó una referencia
                MessageBox.Show("Selecciona una referencia para eliminar.");
            }
        }


        /// <summary>
        /// Carga las referencias asociadas al colaborador seleccionado en el DataGridView.
        /// </summary>
        private void CargarReferencias()
        {
            // Verifica si hay un colaborador seleccionado en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                // Obtiene el ID del colaborador seleccionado
                int colaboradorID = Convert.ToInt32(dgvColaboradores.SelectedRows[0].Cells["ColaboradorID"].Value);

                // Establece las referencias asociadas al colaborador como fuente de datos del DataGridView
                dgvReferencias.DataSource = Referencia.ObtenerReferencias(colaboradorID);
            }
        }

        /// <summary>
        /// Cierra el formulario actual y regresa a la ventana anterior.
        /// </summary>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cada vez que cambia la selección en el DataGridView de colaboradores.
        /// Carga las formaciones, experiencias, habilidades, competencias y referencias asociadas al colaborador seleccionado.
        /// </summary>
        private void dgvColaboradores_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dgvColaboradores.SelectedRows.Count > 0)
            {
                // Obtiene el ID del colaborador seleccionado
                DataGridViewRow row = dgvColaboradores.SelectedRows[0];
                int colaboradorID = Convert.ToInt32(row.Cells["ColaboradorID"].Value);

                using (SqlConnection conexion = new ConexionBD().AbrirConexion())
                {
                    // Query para obtener la foto del colaborador
                    string query = "SELECT Foto FROM Colaboradores WHERE ColaboradorID = @ColaboradorID";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ColaboradorID", colaboradorID);

                    // Ejecuta el comando y obtiene la foto en bytes
                    object fotoObj = comando.ExecuteScalar();
                    if (fotoObj != null && fotoObj != DBNull.Value)
                    {
                        byte[] fotoBytes = (byte[])fotoObj;
                        // Convierte los bytes de la foto a una imagen y la muestra en el PictureBox
                        using (var ms = new MemoryStream(fotoBytes))
                        {
                            pictureBoxFoto.Image = Image.FromStream(ms);
                            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        // Si no hay foto, limpia el PictureBox
                        pictureBoxFoto.Image = null;
                    }
                }
            }

            // Carga las formaciones, experiencias, habilidades, competencias y referencias del colaborador
            CargarFormaciones();
            CargarExperiencias();
            CargarHabilidades();
            CargarCompetencias();
            CargarReferencias();
        }

        /// <summary>
        /// Limpia los campos de texto del formulario.
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDepartamento.Clear();
        }
    }
}
