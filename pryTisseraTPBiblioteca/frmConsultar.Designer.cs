namespace pryTisseraTPBiblioteca
{
    partial class frmConsultar
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
            this.grlLibros = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbTodos = new System.Windows.Forms.GroupBox();
            this.gpbUno = new System.Windows.Forms.GroupBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblResDistribuidor = new System.Windows.Forms.Label();
            this.lblResAutor = new System.Windows.Forms.Label();
            this.lblResEditorial = new System.Windows.Forms.Label();
            this.lblResLibro = new System.Windows.Forms.Label();
            this.lblResCodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlLibros)).BeginInit();
            this.gpbTodos.SuspendLayout();
            this.gpbUno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlLibros
            // 
            this.grlLibros.AllowUserToAddRows = false;
            this.grlLibros.AllowUserToDeleteRows = false;
            this.grlLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colLibro,
            this.colEditorial,
            this.colAutor,
            this.colDistribuidor});
            this.grlLibros.Location = new System.Drawing.Point(6, 19);
            this.grlLibros.Name = "grlLibros";
            this.grlLibros.ReadOnly = true;
            this.grlLibros.Size = new System.Drawing.Size(544, 220);
            this.grlLibros.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colLibro
            // 
            this.colLibro.HeaderText = "Libro";
            this.colLibro.Name = "colLibro";
            this.colLibro.ReadOnly = true;
            // 
            // colEditorial
            // 
            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name = "colEditorial";
            this.colEditorial.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colDistribuidor
            // 
            this.colDistribuidor.HeaderText = "Distribuidor";
            this.colDistribuidor.Name = "colDistribuidor";
            this.colDistribuidor.ReadOnly = true;
            // 
            // gpbTodos
            // 
            this.gpbTodos.Controls.Add(this.grlLibros);
            this.gpbTodos.Location = new System.Drawing.Point(12, 12);
            this.gpbTodos.Name = "gpbTodos";
            this.gpbTodos.Size = new System.Drawing.Size(558, 245);
            this.gpbTodos.TabIndex = 1;
            this.gpbTodos.TabStop = false;
            this.gpbTodos.Text = "Consultar todos";
            // 
            // gpbUno
            // 
            this.gpbUno.Controls.Add(this.btnAnterior);
            this.gpbUno.Controls.Add(this.btnSiguiente);
            this.gpbUno.Controls.Add(this.lblDistribuidor);
            this.gpbUno.Controls.Add(this.lblLibro);
            this.gpbUno.Controls.Add(this.lblEditorial);
            this.gpbUno.Controls.Add(this.lblAutor);
            this.gpbUno.Controls.Add(this.lblResDistribuidor);
            this.gpbUno.Controls.Add(this.lblResAutor);
            this.gpbUno.Controls.Add(this.lblResEditorial);
            this.gpbUno.Controls.Add(this.lblResLibro);
            this.gpbUno.Controls.Add(this.lblResCodigo);
            this.gpbUno.Controls.Add(this.lblCodigo);
            this.gpbUno.Location = new System.Drawing.Point(12, 296);
            this.gpbUno.Name = "gpbUno";
            this.gpbUno.Size = new System.Drawing.Size(558, 249);
            this.gpbUno.TabIndex = 2;
            this.gpbUno.TabStop = false;
            this.gpbUno.Text = "Consultar uno";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(435, 143);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(435, 63);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Location = new System.Drawing.Point(20, 193);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(62, 13);
            this.lblDistribuidor.TabIndex = 9;
            this.lblDistribuidor.Text = "Distribuidor:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(20, 73);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(33, 13);
            this.lblLibro.TabIndex = 8;
            this.lblLibro.Text = "Libro:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(20, 113);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 7;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(20, 153);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor:";
            // 
            // lblResDistribuidor
            // 
            this.lblResDistribuidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDistribuidor.Location = new System.Drawing.Point(94, 192);
            this.lblResDistribuidor.Name = "lblResDistribuidor";
            this.lblResDistribuidor.Size = new System.Drawing.Size(284, 23);
            this.lblResDistribuidor.TabIndex = 5;
            // 
            // lblResAutor
            // 
            this.lblResAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResAutor.Location = new System.Drawing.Point(94, 152);
            this.lblResAutor.Name = "lblResAutor";
            this.lblResAutor.Size = new System.Drawing.Size(284, 23);
            this.lblResAutor.TabIndex = 4;
            // 
            // lblResEditorial
            // 
            this.lblResEditorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEditorial.Location = new System.Drawing.Point(94, 112);
            this.lblResEditorial.Name = "lblResEditorial";
            this.lblResEditorial.Size = new System.Drawing.Size(284, 23);
            this.lblResEditorial.TabIndex = 3;
            // 
            // lblResLibro
            // 
            this.lblResLibro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResLibro.Location = new System.Drawing.Point(94, 72);
            this.lblResLibro.Name = "lblResLibro";
            this.lblResLibro.Size = new System.Drawing.Size(284, 23);
            this.lblResLibro.TabIndex = 2;
            // 
            // lblResCodigo
            // 
            this.lblResCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCodigo.Location = new System.Drawing.Point(94, 32);
            this.lblResCodigo.Name = "lblResCodigo";
            this.lblResCodigo.Size = new System.Drawing.Size(98, 23);
            this.lblResCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(487, 263);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 554);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbUno);
            this.Controls.Add(this.gpbTodos);
            this.Name = "frmConsultar";
            this.Text = "Consultar datos";
            ((System.ComponentModel.ISupportInitialize)(this.grlLibros)).EndInit();
            this.gpbTodos.ResumeLayout(false);
            this.gpbUno.ResumeLayout(false);
            this.gpbUno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistribuidor;
        private System.Windows.Forms.GroupBox gpbTodos;
        private System.Windows.Forms.GroupBox gpbUno;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblResDistribuidor;
        private System.Windows.Forms.Label lblResAutor;
        private System.Windows.Forms.Label lblResEditorial;
        private System.Windows.Forms.Label lblResLibro;
        private System.Windows.Forms.Label lblResCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnConsultar;
    }
}