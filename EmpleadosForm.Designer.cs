namespace GestionDe_RRHH
{
    partial class ColaboradoresForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDatosBasicos = new System.Windows.Forms.TabPage();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.tabFormacionAcademica = new System.Windows.Forms.TabPage();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAñoInicio = new System.Windows.Forms.Label();
            this.numAñoInicio = new System.Windows.Forms.NumericUpDown();
            this.lblAñoFin = new System.Windows.Forms.Label();
            this.numAñoFin = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarFormacion = new System.Windows.Forms.Button();
            this.btnActualizarFormacion = new System.Windows.Forms.Button();
            this.btnEliminarFormacion = new System.Windows.Forms.Button();
            this.dgvFormacionAcademica = new System.Windows.Forms.DataGridView();
            this.tabExperienciaProfesional = new System.Windows.Forms.TabPage();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblAñoInicioExperiencia = new System.Windows.Forms.Label();
            this.numAñoInicioExperiencia = new System.Windows.Forms.NumericUpDown();
            this.lblAñoFinExperiencia = new System.Windows.Forms.Label();
            this.numAñoFinExperiencia = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarExperiencia = new System.Windows.Forms.Button();
            this.btnActualizarExperiencia = new System.Windows.Forms.Button();
            this.btnEliminarExperiencia = new System.Windows.Forms.Button();
            this.dgvExperienciaProfesional = new System.Windows.Forms.DataGridView();
            this.tabHabilidades = new System.Windows.Forms.TabPage();
            this.lblHabilidad = new System.Windows.Forms.Label();
            this.txtHabilidad = new System.Windows.Forms.TextBox();
            this.btnAgregarHabilidad = new System.Windows.Forms.Button();
            this.btnActualizarHabilidad = new System.Windows.Forms.Button();
            this.btnEliminarHabilidad = new System.Windows.Forms.Button();
            this.dgvHabilidades = new System.Windows.Forms.DataGridView();
            this.tabCompetencias = new System.Windows.Forms.TabPage();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.lblDominio = new System.Windows.Forms.Label();
            this.cmbDominio = new System.Windows.Forms.ComboBox();
            this.btnAgregarCompetencia = new System.Windows.Forms.Button();
            this.btnActualizarCompetencia = new System.Windows.Forms.Button();
            this.btnEliminarCompetencia = new System.Windows.Forms.Button();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.tabReferencias = new System.Windows.Forms.TabPage();
            this.lblTipoReferencia = new System.Windows.Forms.Label();
            this.cmbTipoReferencia = new System.Windows.Forms.ComboBox();
            this.lblNombreReferencia = new System.Windows.Forms.Label();
            this.txtNombreReferencia = new System.Windows.Forms.TextBox();
            this.lblTelefonoReferencia = new System.Windows.Forms.Label();
            this.txtTelefonoReferencia = new System.Windows.Forms.TextBox();
            this.btnAgregarReferencia = new System.Windows.Forms.Button();
            this.btnActualizarReferencia = new System.Windows.Forms.Button();
            this.btnEliminarReferencia = new System.Windows.Forms.Button();
            this.dgvReferencias = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabDatosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.tabFormacionAcademica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormacionAcademica)).BeginInit();
            this.tabExperienciaProfesional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoInicioExperiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFinExperiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienciaProfesional)).BeginInit();
            this.tabHabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilidades)).BeginInit();
            this.tabCompetencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.tabReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDatosBasicos);
            this.tabControl.Controls.Add(this.tabFormacionAcademica);
            this.tabControl.Controls.Add(this.tabExperienciaProfesional);
            this.tabControl.Controls.Add(this.tabHabilidades);
            this.tabControl.Controls.Add(this.tabCompetencias);
            this.tabControl.Controls.Add(this.tabReferencias);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 500);
            this.tabControl.TabIndex = 0;
            // 
            // tabDatosBasicos
            // 
            this.tabDatosBasicos.Controls.Add(this.lblNombreCompleto);
            this.tabDatosBasicos.Controls.Add(this.txtNombreCompleto);
            this.tabDatosBasicos.Controls.Add(this.lblTelefono);
            this.tabDatosBasicos.Controls.Add(this.txtTelefono);
            this.tabDatosBasicos.Controls.Add(this.lblEmail);
            this.tabDatosBasicos.Controls.Add(this.txtEmail);
            this.tabDatosBasicos.Controls.Add(this.lblDepartamento);
            this.tabDatosBasicos.Controls.Add(this.txtDepartamento);
            this.tabDatosBasicos.Controls.Add(this.lblObjetivo);
            this.tabDatosBasicos.Controls.Add(this.txtObjetivo);
            this.tabDatosBasicos.Controls.Add(this.pictureBoxFoto);
            this.tabDatosBasicos.Controls.Add(this.btnSeleccionarFoto);
            this.tabDatosBasicos.Controls.Add(this.btnAgregar);
            this.tabDatosBasicos.Controls.Add(this.btnActualizar);
            this.tabDatosBasicos.Controls.Add(this.btnEliminar);
            this.tabDatosBasicos.Controls.Add(this.dgvColaboradores);
            this.tabDatosBasicos.Location = new System.Drawing.Point(4, 28);
            this.tabDatosBasicos.Name = "tabDatosBasicos";
            this.tabDatosBasicos.Size = new System.Drawing.Size(742, 468);
            this.tabDatosBasicos.TabIndex = 0;
            this.tabDatosBasicos.Text = "Datos Básicos";
            this.tabDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(267, 20);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(133, 23);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre Completo:";
          
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreCompleto.Location = new System.Drawing.Point(418, 20);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(303, 19);
            this.txtNombreCompleto.TabIndex = 1;
           
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(267, 60);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(418, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(303, 19);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(267, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(418, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 19);
            this.txtEmail.TabIndex = 5;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(267, 140);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(100, 23);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(418, 140);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(303, 19);
            this.txtDepartamento.TabIndex = 7;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.Location = new System.Drawing.Point(268, 177);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(100, 23);
            this.lblObjetivo.TabIndex = 8;
            this.lblObjetivo.Text = "Objetivo:";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObjetivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjetivo.Location = new System.Drawing.Point(418, 180);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(303, 19);
            this.txtObjetivo.TabIndex = 9;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBoxFoto.Location = new System.Drawing.Point(23, 20);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(229, 180);
            this.pictureBoxFoto.TabIndex = 11;
            this.pictureBoxFoto.TabStop = false;
            
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(84, 232);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionarFoto.TabIndex = 12;
            this.btnSeleccionarFoto.Text = "Seleccionar";
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(271, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(418, 232);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(561, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvColaboradores.ColumnHeadersHeight = 29;
            this.dgvColaboradores.Location = new System.Drawing.Point(54, 278);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.RowHeadersWidth = 51;
            this.dgvColaboradores.Size = new System.Drawing.Size(650, 200);
            this.dgvColaboradores.TabIndex = 11;
            
            // 
            // tabFormacionAcademica
            // 
            this.tabFormacionAcademica.Controls.Add(this.lblInstitucion);
            this.tabFormacionAcademica.Controls.Add(this.txtInstitucion);
            this.tabFormacionAcademica.Controls.Add(this.lblTitulo);
            this.tabFormacionAcademica.Controls.Add(this.txtTitulo);
            this.tabFormacionAcademica.Controls.Add(this.lblAñoInicio);
            this.tabFormacionAcademica.Controls.Add(this.numAñoInicio);
            this.tabFormacionAcademica.Controls.Add(this.lblAñoFin);
            this.tabFormacionAcademica.Controls.Add(this.numAñoFin);
            this.tabFormacionAcademica.Controls.Add(this.btnAgregarFormacion);
            this.tabFormacionAcademica.Controls.Add(this.btnActualizarFormacion);
            this.tabFormacionAcademica.Controls.Add(this.btnEliminarFormacion);
            this.tabFormacionAcademica.Controls.Add(this.dgvFormacionAcademica);
            this.tabFormacionAcademica.Location = new System.Drawing.Point(4, 28);
            this.tabFormacionAcademica.Name = "tabFormacionAcademica";
            this.tabFormacionAcademica.Size = new System.Drawing.Size(742, 468);
            this.tabFormacionAcademica.TabIndex = 1;
            this.tabFormacionAcademica.Text = "Formación Académica";
           
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(34, 41);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(100, 23);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Institución:";
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstitucion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInstitucion.Location = new System.Drawing.Point(164, 41);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(200, 19);
            this.txtInstitucion.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(34, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Location = new System.Drawing.Point(164, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 19);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblAñoInicio
            // 
            this.lblAñoInicio.Location = new System.Drawing.Point(415, 41);
            this.lblAñoInicio.Name = "lblAñoInicio";
            this.lblAñoInicio.Size = new System.Drawing.Size(100, 23);
            this.lblAñoInicio.TabIndex = 4;
            this.lblAñoInicio.Text = "Año Inicio:";
          
            // 
            // numAñoInicio
            // 
            this.numAñoInicio.Location = new System.Drawing.Point(545, 41);
            this.numAñoInicio.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numAñoInicio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAñoInicio.Name = "numAñoInicio";
            this.numAñoInicio.Size = new System.Drawing.Size(120, 26);
            this.numAñoInicio.TabIndex = 5;
            this.numAñoInicio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            
            // 
            // lblAñoFin
            // 
            this.lblAñoFin.Location = new System.Drawing.Point(415, 77);
            this.lblAñoFin.Name = "lblAñoFin";
            this.lblAñoFin.Size = new System.Drawing.Size(100, 23);
            this.lblAñoFin.TabIndex = 6;
            this.lblAñoFin.Text = "Año Fin:";
            // 
            // numAñoFin
            // 
            this.numAñoFin.Location = new System.Drawing.Point(545, 77);
            this.numAñoFin.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numAñoFin.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAñoFin.Name = "numAñoFin";
            this.numAñoFin.Size = new System.Drawing.Size(120, 26);
            this.numAñoFin.TabIndex = 7;
            this.numAñoFin.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnAgregarFormacion
            // 
            this.btnAgregarFormacion.Location = new System.Drawing.Point(104, 332);
            this.btnAgregarFormacion.Name = "btnAgregarFormacion";
            this.btnAgregarFormacion.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarFormacion.TabIndex = 8;
            this.btnAgregarFormacion.Text = "Agregar";
            this.btnAgregarFormacion.Click += new System.EventHandler(this.btnAgregarFormacion_Click);
            // 
            // btnActualizarFormacion
            // 
            this.btnActualizarFormacion.Location = new System.Drawing.Point(327, 332);
            this.btnActualizarFormacion.Name = "btnActualizarFormacion";
            this.btnActualizarFormacion.Size = new System.Drawing.Size(100, 30);
            this.btnActualizarFormacion.TabIndex = 9;
            this.btnActualizarFormacion.Text = "Actualizar";
            this.btnActualizarFormacion.Click += new System.EventHandler(this.btnActualizarFormacion_Click);
            // 
            // btnEliminarFormacion
            // 
            this.btnEliminarFormacion.Location = new System.Drawing.Point(545, 332);
            this.btnEliminarFormacion.Name = "btnEliminarFormacion";
            this.btnEliminarFormacion.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarFormacion.TabIndex = 10;
            this.btnEliminarFormacion.Text = "Eliminar";
            this.btnEliminarFormacion.Click += new System.EventHandler(this.btnEliminarFormacion_Click);
            // 
            // dgvFormacionAcademica
            // 
            this.dgvFormacionAcademica.AllowUserToAddRows = false;
            this.dgvFormacionAcademica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFormacionAcademica.ColumnHeadersHeight = 29;
            this.dgvFormacionAcademica.Location = new System.Drawing.Point(38, 126);
            this.dgvFormacionAcademica.Name = "dgvFormacionAcademica";
            this.dgvFormacionAcademica.ReadOnly = true;
            this.dgvFormacionAcademica.RowHeadersWidth = 51;
            this.dgvFormacionAcademica.Size = new System.Drawing.Size(650, 200);
            this.dgvFormacionAcademica.TabIndex = 11;
            // 
            // tabExperienciaProfesional
            // 
            this.tabExperienciaProfesional.Controls.Add(this.lblEmpresa);
            this.tabExperienciaProfesional.Controls.Add(this.txtEmpresa);
            this.tabExperienciaProfesional.Controls.Add(this.lblPuesto);
            this.tabExperienciaProfesional.Controls.Add(this.txtPuesto);
            this.tabExperienciaProfesional.Controls.Add(this.lblAñoInicioExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.numAñoInicioExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.lblAñoFinExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.numAñoFinExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.btnAgregarExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.btnActualizarExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.btnEliminarExperiencia);
            this.tabExperienciaProfesional.Controls.Add(this.dgvExperienciaProfesional);
            this.tabExperienciaProfesional.Location = new System.Drawing.Point(4, 28);
            this.tabExperienciaProfesional.Name = "tabExperienciaProfesional";
            this.tabExperienciaProfesional.Size = new System.Drawing.Size(742, 468);
            this.tabExperienciaProfesional.TabIndex = 2;
            this.tabExperienciaProfesional.Text = "Experiencia Profesional";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(39, 35);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(100, 23);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.Location = new System.Drawing.Point(169, 35);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(200, 19);
            this.txtEmpresa.TabIndex = 1;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Location = new System.Drawing.Point(39, 75);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(100, 23);
            this.lblPuesto.TabIndex = 2;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Location = new System.Drawing.Point(169, 75);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(200, 19);
            this.txtPuesto.TabIndex = 3;
            // 
            // lblAñoInicioExperiencia
            // 
            this.lblAñoInicioExperiencia.Location = new System.Drawing.Point(419, 35);
            this.lblAñoInicioExperiencia.Name = "lblAñoInicioExperiencia";
            this.lblAñoInicioExperiencia.Size = new System.Drawing.Size(100, 23);
            this.lblAñoInicioExperiencia.TabIndex = 4;
            this.lblAñoInicioExperiencia.Text = "Año Inicio:";
            // 
            // numAñoInicioExperiencia
            // 
            this.numAñoInicioExperiencia.Location = new System.Drawing.Point(549, 35);
            this.numAñoInicioExperiencia.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numAñoInicioExperiencia.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAñoInicioExperiencia.Name = "numAñoInicioExperiencia";
            this.numAñoInicioExperiencia.Size = new System.Drawing.Size(120, 26);
            this.numAñoInicioExperiencia.TabIndex = 5;
            this.numAñoInicioExperiencia.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // lblAñoFinExperiencia
            // 
            this.lblAñoFinExperiencia.Location = new System.Drawing.Point(419, 71);
            this.lblAñoFinExperiencia.Name = "lblAñoFinExperiencia";
            this.lblAñoFinExperiencia.Size = new System.Drawing.Size(100, 23);
            this.lblAñoFinExperiencia.TabIndex = 6;
            this.lblAñoFinExperiencia.Text = "Año Fin:";
            // 
            // numAñoFinExperiencia
            // 
            this.numAñoFinExperiencia.Location = new System.Drawing.Point(549, 71);
            this.numAñoFinExperiencia.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numAñoFinExperiencia.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAñoFinExperiencia.Name = "numAñoFinExperiencia";
            this.numAñoFinExperiencia.Size = new System.Drawing.Size(120, 26);
            this.numAñoFinExperiencia.TabIndex = 7;
            this.numAñoFinExperiencia.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnAgregarExperiencia
            // 
            this.btnAgregarExperiencia.Location = new System.Drawing.Point(94, 323);
            this.btnAgregarExperiencia.Name = "btnAgregarExperiencia";
            this.btnAgregarExperiencia.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarExperiencia.TabIndex = 8;
            this.btnAgregarExperiencia.Text = "Agregar";
            this.btnAgregarExperiencia.Click += new System.EventHandler(this.btnAgregarExperiencia_Click);
            // 
            // btnActualizarExperiencia
            // 
            this.btnActualizarExperiencia.Location = new System.Drawing.Point(336, 323);
            this.btnActualizarExperiencia.Name = "btnActualizarExperiencia";
            this.btnActualizarExperiencia.Size = new System.Drawing.Size(100, 30);
            this.btnActualizarExperiencia.TabIndex = 9;
            this.btnActualizarExperiencia.Text = "Actualizar";
            this.btnActualizarExperiencia.Click += new System.EventHandler(this.btnActualizarExperiencia_Click);
            // 
            // btnEliminarExperiencia
            // 
            this.btnEliminarExperiencia.Location = new System.Drawing.Point(549, 323);
            this.btnEliminarExperiencia.Name = "btnEliminarExperiencia";
            this.btnEliminarExperiencia.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarExperiencia.TabIndex = 10;
            this.btnEliminarExperiencia.Text = "Eliminar";
            this.btnEliminarExperiencia.Click += new System.EventHandler(this.btnEliminarExperiencia_Click);
            // 
            // dgvExperienciaProfesional
            // 
            this.dgvExperienciaProfesional.AllowUserToAddRows = false;
            this.dgvExperienciaProfesional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvExperienciaProfesional.ColumnHeadersHeight = 29;
            this.dgvExperienciaProfesional.Location = new System.Drawing.Point(43, 117);
            this.dgvExperienciaProfesional.Name = "dgvExperienciaProfesional";
            this.dgvExperienciaProfesional.ReadOnly = true;
            this.dgvExperienciaProfesional.RowHeadersWidth = 51;
            this.dgvExperienciaProfesional.Size = new System.Drawing.Size(650, 200);
            this.dgvExperienciaProfesional.TabIndex = 11;
            // 
            // tabHabilidades
            // 
            this.tabHabilidades.Controls.Add(this.lblHabilidad);
            this.tabHabilidades.Controls.Add(this.txtHabilidad);
            this.tabHabilidades.Controls.Add(this.btnAgregarHabilidad);
            this.tabHabilidades.Controls.Add(this.btnActualizarHabilidad);
            this.tabHabilidades.Controls.Add(this.btnEliminarHabilidad);
            this.tabHabilidades.Controls.Add(this.dgvHabilidades);
            this.tabHabilidades.Location = new System.Drawing.Point(4, 28);
            this.tabHabilidades.Name = "tabHabilidades";
            this.tabHabilidades.Size = new System.Drawing.Size(742, 468);
            this.tabHabilidades.TabIndex = 3;
            this.tabHabilidades.Text = "Habilidades";
            // 
            // lblHabilidad
            // 
            this.lblHabilidad.Location = new System.Drawing.Point(194, 49);
            this.lblHabilidad.Name = "lblHabilidad";
            this.lblHabilidad.Size = new System.Drawing.Size(100, 23);
            this.lblHabilidad.TabIndex = 0;
            this.lblHabilidad.Text = "Habilidad:";
        
            // 
            // txtHabilidad
            // 
            this.txtHabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHabilidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHabilidad.Location = new System.Drawing.Point(303, 49);
            this.txtHabilidad.Name = "txtHabilidad";
            this.txtHabilidad.Size = new System.Drawing.Size(240, 19);
            this.txtHabilidad.TabIndex = 1;
        
            // 
            // btnAgregarHabilidad
            // 
            this.btnAgregarHabilidad.Location = new System.Drawing.Point(129, 85);
            this.btnAgregarHabilidad.Name = "btnAgregarHabilidad";
            this.btnAgregarHabilidad.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarHabilidad.TabIndex = 2;
            this.btnAgregarHabilidad.Text = "Agregar";
            this.btnAgregarHabilidad.Click += new System.EventHandler(this.btnAgregarHabilidad_Click);
            // 
            // btnActualizarHabilidad
            // 
            this.btnActualizarHabilidad.Location = new System.Drawing.Point(351, 85);
            this.btnActualizarHabilidad.Name = "btnActualizarHabilidad";
            this.btnActualizarHabilidad.Size = new System.Drawing.Size(80, 30);
            this.btnActualizarHabilidad.TabIndex = 3;
            this.btnActualizarHabilidad.Text = "Actualizar";
            this.btnActualizarHabilidad.Click += new System.EventHandler(this.btnActualizarHabilidad_Click);
            // 
            // btnEliminarHabilidad
            // 
            this.btnEliminarHabilidad.Location = new System.Drawing.Point(563, 85);
            this.btnEliminarHabilidad.Name = "btnEliminarHabilidad";
            this.btnEliminarHabilidad.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarHabilidad.TabIndex = 4;
            this.btnEliminarHabilidad.Text = "Eliminar";
            this.btnEliminarHabilidad.Click += new System.EventHandler(this.btnEliminarHabilidad_Click);
            // 
            // dgvHabilidades
            // 
            this.dgvHabilidades.AllowUserToAddRows = false;
            this.dgvHabilidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvHabilidades.ColumnHeadersHeight = 29;
            this.dgvHabilidades.Location = new System.Drawing.Point(24, 138);
            this.dgvHabilidades.Name = "dgvHabilidades";
            this.dgvHabilidades.ReadOnly = true;
            this.dgvHabilidades.RowHeadersWidth = 51;
            this.dgvHabilidades.Size = new System.Drawing.Size(700, 350);
            this.dgvHabilidades.TabIndex = 5;
            // 
            // tabCompetencias
            // 
            this.tabCompetencias.Controls.Add(this.lblCompetencia);
            this.tabCompetencias.Controls.Add(this.txtCompetencia);
            this.tabCompetencias.Controls.Add(this.lblDominio);
            this.tabCompetencias.Controls.Add(this.cmbDominio);
            this.tabCompetencias.Controls.Add(this.btnAgregarCompetencia);
            this.tabCompetencias.Controls.Add(this.btnActualizarCompetencia);
            this.tabCompetencias.Controls.Add(this.btnEliminarCompetencia);
            this.tabCompetencias.Controls.Add(this.dgvCompetencias);
            this.tabCompetencias.Location = new System.Drawing.Point(4, 28);
            this.tabCompetencias.Name = "tabCompetencias";
            this.tabCompetencias.Size = new System.Drawing.Size(742, 468);
            this.tabCompetencias.TabIndex = 4;
            this.tabCompetencias.Text = "Competencias";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.Location = new System.Drawing.Point(20, 20);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(100, 23);
            this.lblCompetencia.TabIndex = 0;
            this.lblCompetencia.Text = "Competencia:";
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCompetencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompetencia.Location = new System.Drawing.Point(120, 20);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(200, 19);
            this.txtCompetencia.TabIndex = 1;
            // 
            // lblDominio
            // 
            this.lblDominio.Location = new System.Drawing.Point(20, 60);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(100, 23);
            this.lblDominio.TabIndex = 2;
            this.lblDominio.Text = "Dominio:";
            // 
            // cmbDominio
            // 
            this.cmbDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbDominio.Items.AddRange(new object[] {
            "Básico",
            "Intermedio",
            "Avanzado",
            "Experto"});
            this.cmbDominio.Location = new System.Drawing.Point(120, 60);
            this.cmbDominio.Name = "cmbDominio";
            this.cmbDominio.Size = new System.Drawing.Size(200, 27);
            this.cmbDominio.TabIndex = 3;
            // 
            // btnAgregarCompetencia
            // 
            this.btnAgregarCompetencia.Location = new System.Drawing.Point(368, 38);
            this.btnAgregarCompetencia.Name = "btnAgregarCompetencia";
            this.btnAgregarCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarCompetencia.TabIndex = 4;
            this.btnAgregarCompetencia.Text = "Agregar";
            this.btnAgregarCompetencia.Click += new System.EventHandler(this.btnAgregarCompetencia_Click);
            // 
            // btnActualizarCompetencia
            // 
            this.btnActualizarCompetencia.Location = new System.Drawing.Point(503, 38);
            this.btnActualizarCompetencia.Name = "btnActualizarCompetencia";
            this.btnActualizarCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnActualizarCompetencia.TabIndex = 5;
            this.btnActualizarCompetencia.Text = "Actualizar";
            this.btnActualizarCompetencia.Click += new System.EventHandler(this.btnActualizarCompetencia_Click);
            // 
            // btnEliminarCompetencia
            // 
            this.btnEliminarCompetencia.Location = new System.Drawing.Point(624, 38);
            this.btnEliminarCompetencia.Name = "btnEliminarCompetencia";
            this.btnEliminarCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarCompetencia.TabIndex = 6;
            this.btnEliminarCompetencia.Text = "Eliminar";
            this.btnEliminarCompetencia.Click += new System.EventHandler(this.btnEliminarCompetencia_Click);
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AllowUserToAddRows = false;
            this.dgvCompetencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCompetencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompetencias.ColumnHeadersHeight = 29;
            this.dgvCompetencias.Location = new System.Drawing.Point(20, 100);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.ReadOnly = true;
            this.dgvCompetencias.RowHeadersWidth = 51;
            this.dgvCompetencias.Size = new System.Drawing.Size(700, 350);
            this.dgvCompetencias.TabIndex = 7;
            // 
            // tabReferencias
            // 
            this.tabReferencias.Controls.Add(this.lblTipoReferencia);
            this.tabReferencias.Controls.Add(this.cmbTipoReferencia);
            this.tabReferencias.Controls.Add(this.lblNombreReferencia);
            this.tabReferencias.Controls.Add(this.txtNombreReferencia);
            this.tabReferencias.Controls.Add(this.lblTelefonoReferencia);
            this.tabReferencias.Controls.Add(this.txtTelefonoReferencia);
            this.tabReferencias.Controls.Add(this.btnAgregarReferencia);
            this.tabReferencias.Controls.Add(this.btnActualizarReferencia);
            this.tabReferencias.Controls.Add(this.btnEliminarReferencia);
            this.tabReferencias.Controls.Add(this.dgvReferencias);
            this.tabReferencias.Location = new System.Drawing.Point(4, 28);
            this.tabReferencias.Name = "tabReferencias";
            this.tabReferencias.Size = new System.Drawing.Size(742, 468);
            this.tabReferencias.TabIndex = 5;
            this.tabReferencias.Text = "Referencias";
            // 
            // lblTipoReferencia
            // 
            this.lblTipoReferencia.Location = new System.Drawing.Point(92, 21);
            this.lblTipoReferencia.Name = "lblTipoReferencia";
            this.lblTipoReferencia.Size = new System.Drawing.Size(100, 23);
            this.lblTipoReferencia.TabIndex = 0;
            this.lblTipoReferencia.Text = "Tipo:";
            // 
            // cmbTipoReferencia
            // 
            this.cmbTipoReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbTipoReferencia.Items.AddRange(new object[] {
            "Personal",
            "Laboral"});
            this.cmbTipoReferencia.Location = new System.Drawing.Point(222, 21);
            this.cmbTipoReferencia.Name = "cmbTipoReferencia";
            this.cmbTipoReferencia.Size = new System.Drawing.Size(385, 27);
            this.cmbTipoReferencia.TabIndex = 1;
            // 
            // lblNombreReferencia
            // 
            this.lblNombreReferencia.Location = new System.Drawing.Point(92, 61);
            this.lblNombreReferencia.Name = "lblNombreReferencia";
            this.lblNombreReferencia.Size = new System.Drawing.Size(100, 23);
            this.lblNombreReferencia.TabIndex = 2;
            this.lblNombreReferencia.Text = "Nombre:";
            // 
            // txtNombreReferencia
            // 
            this.txtNombreReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNombreReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreReferencia.Location = new System.Drawing.Point(222, 61);
            this.txtNombreReferencia.Name = "txtNombreReferencia";
            this.txtNombreReferencia.Size = new System.Drawing.Size(385, 19);
            this.txtNombreReferencia.TabIndex = 3;
            // 
            // lblTelefonoReferencia
            // 
            this.lblTelefonoReferencia.Location = new System.Drawing.Point(92, 101);
            this.lblTelefonoReferencia.Name = "lblTelefonoReferencia";
            this.lblTelefonoReferencia.Size = new System.Drawing.Size(100, 23);
            this.lblTelefonoReferencia.TabIndex = 4;
            this.lblTelefonoReferencia.Text = "Teléfono:";
            // 
            // txtTelefonoReferencia
            // 
            this.txtTelefonoReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTelefonoReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoReferencia.Location = new System.Drawing.Point(222, 101);
            this.txtTelefonoReferencia.Name = "txtTelefonoReferencia";
            this.txtTelefonoReferencia.Size = new System.Drawing.Size(385, 19);
            this.txtTelefonoReferencia.TabIndex = 5;
            // 
            // btnAgregarReferencia
            // 
            this.btnAgregarReferencia.Location = new System.Drawing.Point(78, 356);
            this.btnAgregarReferencia.Name = "btnAgregarReferencia";
            this.btnAgregarReferencia.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarReferencia.TabIndex = 6;
            this.btnAgregarReferencia.Text = "Agregar";
            this.btnAgregarReferencia.Click += new System.EventHandler(this.btnAgregarReferencia_Click);
            // 
            // btnActualizarReferencia
            // 
            this.btnActualizarReferencia.Location = new System.Drawing.Point(322, 356);
            this.btnActualizarReferencia.Name = "btnActualizarReferencia";
            this.btnActualizarReferencia.Size = new System.Drawing.Size(100, 30);
            this.btnActualizarReferencia.TabIndex = 7;
            this.btnActualizarReferencia.Text = "Actualizar";
            this.btnActualizarReferencia.Click += new System.EventHandler(this.btnActualizarReferencia_Click);
            // 
            // btnEliminarReferencia
            // 
            this.btnEliminarReferencia.Location = new System.Drawing.Point(556, 356);
            this.btnEliminarReferencia.Name = "btnEliminarReferencia";
            this.btnEliminarReferencia.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarReferencia.TabIndex = 8;
            this.btnEliminarReferencia.Text = "Eliminar";
            this.btnEliminarReferencia.Click += new System.EventHandler(this.btnEliminarReferencia_Click);
            // 
            // dgvReferencias
            // 
            this.dgvReferencias.AllowUserToAddRows = false;
            this.dgvReferencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvReferencias.ColumnHeadersHeight = 29;
            this.dgvReferencias.Location = new System.Drawing.Point(20, 150);
            this.dgvReferencias.Name = "dgvReferencias";
            this.dgvReferencias.ReadOnly = true;
            this.dgvReferencias.RowHeadersWidth = 51;
            this.dgvReferencias.Size = new System.Drawing.Size(650, 200);
            this.dgvReferencias.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRegresar.Location = new System.Drawing.Point(660, 534);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ColaboradoresForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 564);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ColaboradoresForm";
            this.tabControl.ResumeLayout(false);
            this.tabDatosBasicos.ResumeLayout(false);
            this.tabDatosBasicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.tabFormacionAcademica.ResumeLayout(false);
            this.tabFormacionAcademica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormacionAcademica)).EndInit();
            this.tabExperienciaProfesional.ResumeLayout(false);
            this.tabExperienciaProfesional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoInicioExperiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFinExperiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperienciaProfesional)).EndInit();
            this.tabHabilidades.ResumeLayout(false);
            this.tabHabilidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilidades)).EndInit();
            this.tabCompetencias.ResumeLayout(false);
            this.tabCompetencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.tabReferencias.ResumeLayout(false);
            this.tabReferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnSeleccionarFoto;

        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDatosBasicos;
        private System.Windows.Forms.TabPage tabFormacionAcademica;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAñoInicio;
        private System.Windows.Forms.Label lblAñoFin;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.NumericUpDown numAñoInicio;
        private System.Windows.Forms.NumericUpDown numAñoFin;
        private System.Windows.Forms.Button btnAgregarFormacion;
        private System.Windows.Forms.Button btnActualizarFormacion;
        private System.Windows.Forms.Button btnEliminarFormacion;
        private System.Windows.Forms.DataGridView dgvFormacionAcademica;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabPage tabExperienciaProfesional;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblAñoInicioExperiencia;
        private System.Windows.Forms.Label lblAñoFinExperiencia;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.NumericUpDown numAñoInicioExperiencia;
        private System.Windows.Forms.NumericUpDown numAñoFinExperiencia;
        private System.Windows.Forms.Button btnAgregarExperiencia;
        private System.Windows.Forms.Button btnActualizarExperiencia;
        private System.Windows.Forms.Button btnEliminarExperiencia;
        private System.Windows.Forms.DataGridView dgvExperienciaProfesional;
        private System.Windows.Forms.TabPage tabHabilidades;
        private System.Windows.Forms.Label lblHabilidad;
        private System.Windows.Forms.TextBox txtHabilidad;
        private System.Windows.Forms.Button btnAgregarHabilidad;
        private System.Windows.Forms.Button btnActualizarHabilidad;
        private System.Windows.Forms.Button btnEliminarHabilidad;
        private System.Windows.Forms.DataGridView dgvHabilidades;
        private System.Windows.Forms.TabPage tabCompetencias;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.Button btnAgregarCompetencia;
        private System.Windows.Forms.Button btnActualizarCompetencia;
        private System.Windows.Forms.Button btnEliminarCompetencia;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.ComboBox cmbDominio;
        private System.Windows.Forms.TabPage tabReferencias;
        private System.Windows.Forms.Label lblTipoReferencia;
        private System.Windows.Forms.ComboBox cmbTipoReferencia;
        private System.Windows.Forms.Label lblNombreReferencia;
        private System.Windows.Forms.TextBox txtNombreReferencia;
        private System.Windows.Forms.Label lblTelefonoReferencia;
        private System.Windows.Forms.TextBox txtTelefonoReferencia;
        private System.Windows.Forms.Button btnAgregarReferencia;
        private System.Windows.Forms.Button btnActualizarReferencia;
        private System.Windows.Forms.Button btnEliminarReferencia;
        private System.Windows.Forms.DataGridView dgvReferencias;



    }

}