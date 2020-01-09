namespace Crud
{
    partial class Raiz
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtEO = new System.Windows.Forms.TextBox();
            this.lblEO = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(477, 58);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(338, 97);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Plan";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(196, 213);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(114, 17);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "Seleccionar Plan";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(656, 213);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(140, 65);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtEO
            // 
            this.txtEO.Location = new System.Drawing.Point(52, 88);
            this.txtEO.Name = "txtEO";
            this.txtEO.Size = new System.Drawing.Size(402, 22);
            this.txtEO.TabIndex = 4;
            this.txtEO.TextChanged += new System.EventHandler(this.txtEO_TextChanged);
            // 
            // lblEO
            // 
            this.lblEO.AutoSize = true;
            this.lblEO.Location = new System.Drawing.Point(175, 58);
            this.lblEO.Name = "lblEO";
            this.lblEO.Size = new System.Drawing.Size(181, 17);
            this.lblEO.TabIndex = 5;
            this.lblEO.Text = "Nombre de la Organización";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(158, 152);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(477, 213);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 61);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Raiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 351);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblEO);
            this.Controls.Add(this.txtEO);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Raiz";
            this.Text = "PLAN C";
            this.Load += new System.EventHandler(this.Raiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtEO;
        private System.Windows.Forms.Label lblEO;
        private System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}