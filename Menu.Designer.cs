namespace GestionDe_RRHH
{
    partial class MainMenuForm
    {
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnGestionColaboradores = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(82, 42);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(399, 31);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido al sistema de Gestión";
            // 
            // btnGestionColaboradores
            // 
            this.btnGestionColaboradores.BackColor = System.Drawing.Color.Silver;
            this.btnGestionColaboradores.Location = new System.Drawing.Point(32, 102);
            this.btnGestionColaboradores.Name = "btnGestionColaboradores";
            this.btnGestionColaboradores.Size = new System.Drawing.Size(243, 70);
            this.btnGestionColaboradores.TabIndex = 1;
            this.btnGestionColaboradores.Text = "Gestión de Colaboradores";
            this.btnGestionColaboradores.UseVisualStyleBackColor = false;
            this.btnGestionColaboradores.Click += new System.EventHandler(this.btnGestionColaboradores_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.Color.Silver;
            this.btnEquipo.Location = new System.Drawing.Point(32, 338);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(165, 37);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Desarrolladores";
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Silver;
            this.btnHistorial.Location = new System.Drawing.Point(298, 102);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(243, 70);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial de Actividades";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Silver;
            this.btnBusqueda.Location = new System.Drawing.Point(32, 216);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(243, 70);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(446, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(298, 216);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(243, 70);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(566, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.btnGestionColaboradores);
            this.Controls.Add(this.lblBienvenida);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenuForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnGestionColaboradores;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnAgregarUsuario; // Declaración del nuevo botón
        private System.Windows.Forms.Button btnSalir;
    }
}