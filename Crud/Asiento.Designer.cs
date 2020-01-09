namespace Crud
{
    partial class Asiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarAsiento = new System.Windows.Forms.Button();
            this.btnFinalizarAsiento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.comboCuenta = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDebe = new System.Windows.Forms.RadioButton();
            this.rdbHaber = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblBuscarFecha = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAsiento
            // 
            this.btnAgregarAsiento.Location = new System.Drawing.Point(371, 12);
            this.btnAgregarAsiento.Name = "btnAgregarAsiento";
            this.btnAgregarAsiento.Size = new System.Drawing.Size(152, 60);
            this.btnAgregarAsiento.TabIndex = 0;
            this.btnAgregarAsiento.Text = "Agregar Asiento";
            this.btnAgregarAsiento.UseVisualStyleBackColor = true;
            this.btnAgregarAsiento.Click += new System.EventHandler(this.btnAgregarAsiento_Click);
            // 
            // btnFinalizarAsiento
            // 
            this.btnFinalizarAsiento.Location = new System.Drawing.Point(540, 12);
            this.btnFinalizarAsiento.Name = "btnFinalizarAsiento";
            this.btnFinalizarAsiento.Size = new System.Drawing.Size(143, 60);
            this.btnFinalizarAsiento.TabIndex = 1;
            this.btnFinalizarAsiento.Text = "Finalizar Asiento";
            this.btnFinalizarAsiento.UseVisualStyleBackColor = true;
            this.btnFinalizarAsiento.Click += new System.EventHandler(this.btnFinalizarAsiento_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(384, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 60);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(130, 233);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(174, 84);
            this.btnLibro.TabIndex = 3;
            this.btnLibro.Text = "Mostrar Libro Diario";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(614, 227);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(155, 84);
            this.btnMayor.TabIndex = 4;
            this.btnMayor.Text = "Generar Libro Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // comboCuenta
            // 
            this.comboCuenta.FormattingEnabled = true;
            this.comboCuenta.Location = new System.Drawing.Point(27, 111);
            this.comboCuenta.Name = "comboCuenta";
            this.comboCuenta.Size = new System.Drawing.Size(121, 24);
            this.comboCuenta.TabIndex = 9;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(61, 91);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(53, 17);
            this.lblCuenta.TabIndex = 10;
            this.lblCuenta.Text = "Cuenta";
            // 
            // dtp1
            // 
            this.dtp1.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dtp1.Location = new System.Drawing.Point(204, 113);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 11;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(278, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(482, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(427, 115);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(149, 22);
            this.txtValor.TabIndex = 14;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDebe);
            this.groupBox1.Controls.Add(this.rdbHaber);
            this.groupBox1.Location = new System.Drawing.Point(597, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija";
            // 
            // rdbDebe
            // 
            this.rdbDebe.AutoSize = true;
            this.rdbDebe.Checked = true;
            this.rdbDebe.Location = new System.Drawing.Point(6, 31);
            this.rdbDebe.Name = "rdbDebe";
            this.rdbDebe.Size = new System.Drawing.Size(63, 21);
            this.rdbDebe.TabIndex = 3;
            this.rdbDebe.TabStop = true;
            this.rdbDebe.Text = "Debe";
            this.rdbDebe.UseVisualStyleBackColor = true;
            // 
            // rdbHaber
            // 
            this.rdbHaber.AutoSize = true;
            this.rdbHaber.Location = new System.Drawing.Point(122, 31);
            this.rdbHaber.Name = "rdbHaber";
            this.rdbHaber.Size = new System.Drawing.Size(68, 21);
            this.rdbHaber.TabIndex = 2;
            this.rdbHaber.Text = "Haber";
            this.rdbHaber.UseVisualStyleBackColor = true;
            this.rdbHaber.CheckedChanged += new System.EventHandler(this.rdbHaber_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(868, 95);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(87, 77);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(44, 184);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 37);
            this.btnAñadir.TabIndex = 17;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(371, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 64);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar Asiento";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(201, 369);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(75, 17);
            this.lblOrden.TabIndex = 19;
            this.lblOrden.Text = "Asiento N°";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(710, 347);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 50);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(282, 364);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(100, 22);
            this.txtOrden.TabIndex = 21;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(64, 411);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(837, 158);
            this.data.TabIndex = 22;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(44, 141);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 37);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBuscarFecha
            // 
            this.lblBuscarFecha.AutoSize = true;
            this.lblBuscarFecha.Location = new System.Drawing.Point(413, 364);
            this.lblBuscarFecha.Name = "lblBuscarFecha";
            this.lblBuscarFecha.Size = new System.Drawing.Size(47, 17);
            this.lblBuscarFecha.TabIndex = 26;
            this.lblBuscarFecha.Text = "Fecha";
            // 
            // dtp2
            // 
            this.dtp2.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dtp2.Location = new System.Drawing.Point(466, 362);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 22);
            this.dtp2.TabIndex = 25;
            // 
            // Asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 598);
            this.Controls.Add(this.lblBuscarFecha);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.comboCuenta);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarAsiento);
            this.Controls.Add(this.btnAgregarAsiento);
            this.Name = "Asiento";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.Work_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAsiento;
        private System.Windows.Forms.Button btnFinalizarAsiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.ComboBox comboCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDebe;
        private System.Windows.Forms.RadioButton rdbHaber;
        private System.Windows.Forms.Button btnCargar;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblBuscarFecha;
        private System.Windows.Forms.DateTimePicker dtp2;
    }
}