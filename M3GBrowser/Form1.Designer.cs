
namespace M3GBrowser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Navegar = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAlante = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.txtDireccion = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.cboHistorial = new System.Windows.Forms.ToolStripComboBox();
            this.btnHistorial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItla = new System.Windows.Forms.ToolStripButton();
            this.btnOrbi = new System.Windows.Forms.ToolStripButton();
            this.btnOffice = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAlante,
            this.btnRefrescar,
            this.btnHome,
            this.txtDireccion,
            this.btnGo,
            this.cboHistorial,
            this.btnHistorial,
            this.toolStripSeparator1,
            this.btnItla,
            this.btnOrbi,
            this.btnOffice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1233, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Navegar
            // 
            this.Navegar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navegar.Location = new System.Drawing.Point(0, 28);
            this.Navegar.MinimumSize = new System.Drawing.Size(20, 20);
            this.Navegar.Name = "Navegar";
            this.Navegar.Size = new System.Drawing.Size(1233, 422);
            this.Navegar.TabIndex = 1;
            this.Navegar.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Navegar_DocumentCompleted);
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(29, 25);
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAlante
            // 
            this.btnAlante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlante.Image = ((System.Drawing.Image)(resources.GetObject("btnAlante.Image")));
            this.btnAlante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlante.Name = "btnAlante";
            this.btnAlante.Size = new System.Drawing.Size(29, 25);
            this.btnAlante.Text = "Adelante";
            this.btnAlante.Click += new System.EventHandler(this.btnAlante_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(29, 25);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(29, 25);
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(700, 28);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 25);
            this.btnGo.Text = "Buscar";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cboHistorial
            // 
            this.cboHistorial.Name = "cboHistorial";
            this.cboHistorial.Size = new System.Drawing.Size(121, 28);
            this.cboHistorial.SelectedIndexChanged += new System.EventHandler(this.cboHistorial_SelectedIndexChanged);
            // 
            // btnHistorial
            // 
            this.btnHistorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(29, 25);
            this.btnHistorial.Text = "Favoritos";
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnItla
            // 
            this.btnItla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItla.Image = ((System.Drawing.Image)(resources.GetObject("btnItla.Image")));
            this.btnItla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItla.Name = "btnItla";
            this.btnItla.Size = new System.Drawing.Size(29, 25);
            this.btnItla.Text = "ITLA";
            this.btnItla.Click += new System.EventHandler(this.btnItla_Click);
            // 
            // btnOrbi
            // 
            this.btnOrbi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrbi.Image = ((System.Drawing.Image)(resources.GetObject("btnOrbi.Image")));
            this.btnOrbi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrbi.Name = "btnOrbi";
            this.btnOrbi.Size = new System.Drawing.Size(29, 25);
            this.btnOrbi.Text = "Orbi";
            this.btnOrbi.Click += new System.EventHandler(this.btnOrbi_Click);
            // 
            // btnOffice
            // 
            this.btnOffice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOffice.Image = ((System.Drawing.Image)(resources.GetObject("btnOffice.Image")));
            this.btnOffice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffice.Name = "btnOffice";
            this.btnOffice.Size = new System.Drawing.Size(29, 25);
            this.btnOffice.Text = "Office";
            this.btnOffice.Click += new System.EventHandler(this.btnOffice_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.Navegar);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "ITLABrowser";
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.WebBrowser Navegar;
        private System.Windows.Forms.ToolStripButton btnAlante;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripTextBox txtDireccion;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripComboBox cboHistorial;
        private System.Windows.Forms.ToolStripButton btnHistorial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnItla;
        private System.Windows.Forms.ToolStripButton btnOrbi;
        private System.Windows.Forms.ToolStripButton btnOffice;
    }
}

