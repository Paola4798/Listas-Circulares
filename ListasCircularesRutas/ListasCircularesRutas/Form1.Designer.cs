namespace ListasCircularesRutas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMinAInsertar = new System.Windows.Forms.TextBox();
            this.txtBaseAInsertar = new System.Windows.Forms.TextBox();
            this.lblBaseAInsertar = new System.Windows.Forms.Label();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtNombreRecorrido = new System.Windows.Forms.TextBox();
            this.lblNombreRecorrido = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtInsertarDespuesDe = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInsertarDespuesDe = new System.Windows.Forms.Button();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnAgregarEnInicio = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMinutosDesdeBaseAnterior = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMinutosDesdeBaseAnterior = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinAInsertar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMinAInsertar
            // 
            this.txtMinAInsertar.Location = new System.Drawing.Point(422, 85);
            this.txtMinAInsertar.Name = "txtMinAInsertar";
            this.txtMinAInsertar.Size = new System.Drawing.Size(107, 20);
            this.txtMinAInsertar.TabIndex = 79;
            // 
            // txtBaseAInsertar
            // 
            this.txtBaseAInsertar.Location = new System.Drawing.Point(302, 76);
            this.txtBaseAInsertar.Name = "txtBaseAInsertar";
            this.txtBaseAInsertar.Size = new System.Drawing.Size(89, 20);
            this.txtBaseAInsertar.TabIndex = 78;
            // 
            // lblBaseAInsertar
            // 
            this.lblBaseAInsertar.AutoSize = true;
            this.lblBaseAInsertar.Location = new System.Drawing.Point(311, 60);
            this.lblBaseAInsertar.Name = "lblBaseAInsertar";
            this.lblBaseAInsertar.Size = new System.Drawing.Size(80, 13);
            this.lblBaseAInsertar.TabIndex = 76;
            this.lblBaseAInsertar.Text = "Base a insertar:";
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUltimo.Location = new System.Drawing.Point(191, 195);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarUltimo.TabIndex = 75;
            this.btnEliminarUltimo.Text = "Eliminar último";
            this.btnEliminarUltimo.UseVisualStyleBackColor = false;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrimero.Location = new System.Drawing.Point(103, 195);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarPrimero.TabIndex = 74;
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = false;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(585, 99);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(47, 13);
            this.lblHoraFin.TabIndex = 73;
            this.lblHoraFin.Text = "Hora fin:";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(647, 93);
            this.dtpHoraFin.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(111, 20);
            this.dtpHoraFin.TabIndex = 72;
            this.dtpHoraFin.Value = new System.DateTime(2017, 5, 11, 22, 49, 18, 0);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(585, 68);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(60, 13);
            this.lblHoraInicio.TabIndex = 71;
            this.lblHoraInicio.Text = "Hora inicio:";
            // 
            // txtNombreRecorrido
            // 
            this.txtNombreRecorrido.Location = new System.Drawing.Point(647, 32);
            this.txtNombreRecorrido.Name = "txtNombreRecorrido";
            this.txtNombreRecorrido.Size = new System.Drawing.Size(111, 20);
            this.txtNombreRecorrido.TabIndex = 70;
            // 
            // lblNombreRecorrido
            // 
            this.lblNombreRecorrido.AutoSize = true;
            this.lblNombreRecorrido.Location = new System.Drawing.Point(585, 35);
            this.lblNombreRecorrido.Name = "lblNombreRecorrido";
            this.lblNombreRecorrido.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRecorrido.TabIndex = 69;
            this.lblNombreRecorrido.Text = "Nombre:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(647, 62);
            this.dtpHoraInicio.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpHoraInicio.TabIndex = 68;
            this.dtpHoraInicio.Value = new System.DateTime(2017, 5, 11, 22, 49, 18, 0);
            // 
            // txtInsertarDespuesDe
            // 
            this.txtInsertarDespuesDe.Location = new System.Drawing.Point(447, 18);
            this.txtInsertarDespuesDe.Name = "txtInsertarDespuesDe";
            this.txtInsertarDespuesDe.Size = new System.Drawing.Size(111, 20);
            this.txtInsertarDespuesDe.TabIndex = 67;
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(290, 164);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(562, 223);
            this.txtReporte.TabIndex = 65;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightCoral;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(103, 250);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 38);
            this.btnReporte.TabIndex = 64;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnInsertarDespuesDe
            // 
            this.btnInsertarDespuesDe.BackColor = System.Drawing.Color.LightCoral;
            this.btnInsertarDespuesDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarDespuesDe.Location = new System.Drawing.Point(377, 121);
            this.btnInsertarDespuesDe.Name = "btnInsertarDespuesDe";
            this.btnInsertarDespuesDe.Size = new System.Drawing.Size(64, 37);
            this.btnInsertarDespuesDe.TabIndex = 63;
            this.btnInsertarDespuesDe.Text = "Insertar ";
            this.btnInsertarDespuesDe.UseVisualStyleBackColor = false;
            this.btnInsertarDespuesDe.Click += new System.EventHandler(this.btnInsertarDespuesDe_Click);
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.BackColor = System.Drawing.Color.LightCoral;
            this.btnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrido.Location = new System.Drawing.Point(766, 55);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(75, 38);
            this.btnRecorrido.TabIndex = 62;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = false;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnAgregarEnInicio
            // 
            this.btnAgregarEnInicio.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregarEnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEnInicio.Location = new System.Drawing.Point(191, 142);
            this.btnAgregarEnInicio.Name = "btnAgregarEnInicio";
            this.btnAgregarEnInicio.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarEnInicio.TabIndex = 61;
            this.btnAgregarEnInicio.Text = "Agregar en inicio";
            this.btnAgregarEnInicio.UseVisualStyleBackColor = false;
            this.btnAgregarEnInicio.Click += new System.EventHandler(this.btnAgregarEnInicio_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(15, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightCoral;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(103, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(15, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 38);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMinutosDesdeBaseAnterior
            // 
            this.txtMinutosDesdeBaseAnterior.Location = new System.Drawing.Point(160, 103);
            this.txtMinutosDesdeBaseAnterior.Name = "txtMinutosDesdeBaseAnterior";
            this.txtMinutosDesdeBaseAnterior.Size = new System.Drawing.Size(107, 20);
            this.txtMinutosDesdeBaseAnterior.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // lblMinutosDesdeBaseAnterior
            // 
            this.lblMinutosDesdeBaseAnterior.Location = new System.Drawing.Point(157, 73);
            this.lblMinutosDesdeBaseAnterior.Name = "lblMinutosDesdeBaseAnterior";
            this.lblMinutosDesdeBaseAnterior.Size = new System.Drawing.Size(118, 27);
            this.lblMinutosDesdeBaseAnterior.TabIndex = 55;
            this.lblMinutosDesdeBaseAnterior.Text = "Minutos desde la base anterior:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Insertar despues de la base:";
            // 
            // lblMinAInsertar
            // 
            this.lblMinAInsertar.Location = new System.Drawing.Point(419, 55);
            this.lblMinAInsertar.Name = "lblMinAInsertar";
            this.lblMinAInsertar.Size = new System.Drawing.Size(139, 27);
            this.lblMinAInsertar.TabIndex = 77;
            this.lblMinAInsertar.Text = "Minutos desde la base anterior:";
            this.lblMinAInsertar.Click += new System.EventHandler(this.lblMinAInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(898, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinAInsertar);
            this.Controls.Add(this.txtBaseAInsertar);
            this.Controls.Add(this.lblMinAInsertar);
            this.Controls.Add(this.lblBaseAInsertar);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.txtNombreRecorrido);
            this.Controls.Add(this.lblNombreRecorrido);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.txtInsertarDespuesDe);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInsertarDespuesDe);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnAgregarEnInicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMinutosDesdeBaseAnterior);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMinutosDesdeBaseAnterior);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinAInsertar;
        private System.Windows.Forms.TextBox txtBaseAInsertar;
        private System.Windows.Forms.Label lblBaseAInsertar;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TextBox txtNombreRecorrido;
        private System.Windows.Forms.Label lblNombreRecorrido;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.TextBox txtInsertarDespuesDe;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnInsertarDespuesDe;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnAgregarEnInicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMinutosDesdeBaseAnterior;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMinutosDesdeBaseAnterior;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinAInsertar;
    }
}

