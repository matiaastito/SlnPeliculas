namespace WindowsAppPeliculas
{
    partial class frmPeliculas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblCantMinutos = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdModif = new System.Windows.Forms.TextBox();
            this.lblIdElim = new System.Windows.Forms.Label();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gridPeliculas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblGeneroBusq = new System.Windows.Forms.Label();
            this.txtGeneroBusq = new System.Windows.Forms.TextBox();
            this.gridGeneros = new System.Windows.Forms.DataGridView();
            this.gridClasificaciones = new System.Windows.Forms.DataGridView();
            this.dateFechaEstreno = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClasificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(149, 76);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(213, 20);
            this.txtClasificacion.TabIndex = 1;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(149, 126);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(213, 20);
            this.txtDuracion.TabIndex = 4;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(149, 152);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(213, 20);
            this.txtGenero.TabIndex = 5;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(149, 178);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(213, 20);
            this.txtIdioma.TabIndex = 6;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(149, 204);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(213, 20);
            this.txtSinopsis.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(39, 79);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 10;
            this.lblClasificacion.Text = "Clasificacion:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(39, 105);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEstreno.TabIndex = 11;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            // 
            // lblCantMinutos
            // 
            this.lblCantMinutos.AutoSize = true;
            this.lblCantMinutos.Location = new System.Drawing.Point(39, 129);
            this.lblCantMinutos.Name = "lblCantMinutos";
            this.lblCantMinutos.Size = new System.Drawing.Size(108, 13);
            this.lblCantMinutos.TabIndex = 12;
            this.lblCantMinutos.Text = "Duración en Minutos:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(39, 155);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Genero:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(39, 181);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 14;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(39, 207);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSinopsis.TabIndex = 15;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(141, 9);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(108, 25);
            this.lblPelicula.TabIndex = 16;
            this.lblPelicula.Text = "PELICULA";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(255, 230);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(107, 23);
            this.btnInsertar.TabIndex = 17;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(534, 43);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(392, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Id:";
            // 
            // txtIdModif
            // 
            this.txtIdModif.Location = new System.Drawing.Point(417, 44);
            this.txtIdModif.Name = "txtIdModif";
            this.txtIdModif.Size = new System.Drawing.Size(100, 20);
            this.txtIdModif.TabIndex = 19;
            // 
            // lblIdElim
            // 
            this.lblIdElim.AutoSize = true;
            this.lblIdElim.Location = new System.Drawing.Point(392, 78);
            this.lblIdElim.Name = "lblIdElim";
            this.lblIdElim.Size = new System.Drawing.Size(19, 13);
            this.lblIdElim.TabIndex = 23;
            this.lblIdElim.Text = "Id:";
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(417, 74);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdEliminar.TabIndex = 22;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(534, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gridPeliculas
            // 
            this.gridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeliculas.Location = new System.Drawing.Point(633, 105);
            this.gridPeliculas.Name = "gridPeliculas";
            this.gridPeliculas.Size = new System.Drawing.Size(266, 363);
            this.gridPeliculas.TabIndex = 24;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(831, 66);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 25;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblGeneroBusq
            // 
            this.lblGeneroBusq.AutoSize = true;
            this.lblGeneroBusq.Location = new System.Drawing.Point(660, 71);
            this.lblGeneroBusq.Name = "lblGeneroBusq";
            this.lblGeneroBusq.Size = new System.Drawing.Size(45, 13);
            this.lblGeneroBusq.TabIndex = 27;
            this.lblGeneroBusq.Text = "Genero:";
            // 
            // txtGeneroBusq
            // 
            this.txtGeneroBusq.Location = new System.Drawing.Point(711, 66);
            this.txtGeneroBusq.Name = "txtGeneroBusq";
            this.txtGeneroBusq.Size = new System.Drawing.Size(100, 20);
            this.txtGeneroBusq.TabIndex = 26;
            // 
            // gridGeneros
            // 
            this.gridGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGeneros.Location = new System.Drawing.Point(42, 288);
            this.gridGeneros.Name = "gridGeneros";
            this.gridGeneros.Size = new System.Drawing.Size(305, 113);
            this.gridGeneros.TabIndex = 28;
            // 
            // gridClasificaciones
            // 
            this.gridClasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClasificaciones.Location = new System.Drawing.Point(395, 127);
            this.gridClasificaciones.Name = "gridClasificaciones";
            this.gridClasificaciones.Size = new System.Drawing.Size(214, 97);
            this.gridClasificaciones.TabIndex = 29;
            // 
            // dateFechaEstreno
            // 
            this.dateFechaEstreno.Location = new System.Drawing.Point(149, 102);
            this.dateFechaEstreno.Name = "dateFechaEstreno";
            this.dateFechaEstreno.Size = new System.Drawing.Size(213, 20);
            this.dateFechaEstreno.TabIndex = 30;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 507);
            this.Controls.Add(this.dateFechaEstreno);
            this.Controls.Add(this.gridClasificaciones);
            this.Controls.Add(this.gridGeneros);
            this.Controls.Add(this.lblGeneroBusq);
            this.Controls.Add(this.txtGeneroBusq);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridPeliculas);
            this.Controls.Add(this.lblIdElim);
            this.Controls.Add(this.txtIdEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdModif);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCantMinutos);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmPeliculas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClasificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblCantMinutos;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdModif;
        private System.Windows.Forms.Label lblIdElim;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView gridPeliculas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblGeneroBusq;
        private System.Windows.Forms.TextBox txtGeneroBusq;
        private System.Windows.Forms.DataGridView gridGeneros;
        private System.Windows.Forms.DataGridView gridClasificaciones;
        private System.Windows.Forms.DateTimePicker dateFechaEstreno;
    }
}

