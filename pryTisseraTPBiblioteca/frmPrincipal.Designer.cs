namespace pryTisseraTPBiblioteca
{
    partial class frmPrincipal
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
            this.msOperaciones = new System.Windows.Forms.MenuStrip();
            this.msGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.msConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.msSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.msModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOperaciones
            // 
            this.msOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msGestion,
            this.msConsulta,
            this.msSalir});
            this.msOperaciones.Location = new System.Drawing.Point(0, 0);
            this.msOperaciones.Name = "msOperaciones";
            this.msOperaciones.Size = new System.Drawing.Size(800, 24);
            this.msOperaciones.TabIndex = 0;
            this.msOperaciones.Text = "menuStrip1";
            // 
            // msGestion
            // 
            this.msGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCargar,
            this.msModificar});
            this.msGestion.Name = "msGestion";
            this.msGestion.Size = new System.Drawing.Size(59, 20);
            this.msGestion.Text = "Gestión";
            // 
            // msConsulta
            // 
            this.msConsulta.Name = "msConsulta";
            this.msConsulta.Size = new System.Drawing.Size(66, 20);
            this.msConsulta.Text = "Consulta";
            this.msConsulta.Click += new System.EventHandler(this.msConsulta_Click);
            // 
            // msSalir
            // 
            this.msSalir.Name = "msSalir";
            this.msSalir.Size = new System.Drawing.Size(41, 20);
            this.msSalir.Text = "Salir";
            // 
            // msCargar
            // 
            this.msCargar.Name = "msCargar";
            this.msCargar.Size = new System.Drawing.Size(180, 22);
            this.msCargar.Text = "Cargar";
            this.msCargar.Click += new System.EventHandler(this.msCargar_Click);
            // 
            // msModificar
            // 
            this.msModificar.Name = "msModificar";
            this.msModificar.Size = new System.Drawing.Size(180, 22);
            this.msModificar.Text = "Modificar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msOperaciones);
            this.MainMenuStrip = this.msOperaciones;
            this.Name = "frmPrincipal";
            this.Text = "Base de datos biblioteca";
            this.msOperaciones.ResumeLayout(false);
            this.msOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOperaciones;
        private System.Windows.Forms.ToolStripMenuItem msGestion;
        private System.Windows.Forms.ToolStripMenuItem msCargar;
        private System.Windows.Forms.ToolStripMenuItem msModificar;
        private System.Windows.Forms.ToolStripMenuItem msConsulta;
        private System.Windows.Forms.ToolStripMenuItem msSalir;
    }
}

