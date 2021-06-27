
namespace GestorComprobantes
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lista_boletas = new System.Windows.Forms.ListBox();
            this.lblBoletas = new System.Windows.Forms.Label();
            this.bmenu_servicios = new System.Windows.Forms.Button();
            this.select_servicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_servicios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bNuevaBoleta = new System.Windows.Forms.Button();
            this.bCargarBoletas = new System.Windows.Forms.Button();
            this.pdfBoleta = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.pdfComprobante = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.bEditarBoleta = new System.Windows.Forms.Button();
            this.gbDatosBoleta = new System.Windows.Forms.GroupBox();
            this.bNuevoComprobante = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVencimiento = new System.Windows.Forms.Panel();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.bEditarComprobante = new System.Windows.Forms.Button();
            this.menu_servicios.SuspendLayout();
            this.gbDatosBoleta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVencimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista_boletas
            // 
            this.lista_boletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lista_boletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista_boletas.Enabled = false;
            this.lista_boletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_boletas.FormattingEnabled = true;
            this.lista_boletas.ItemHeight = 24;
            this.lista_boletas.Location = new System.Drawing.Point(12, 120);
            this.lista_boletas.Name = "lista_boletas";
            this.lista_boletas.Size = new System.Drawing.Size(136, 362);
            this.lista_boletas.TabIndex = 1;
            this.lista_boletas.SelectedIndexChanged += new System.EventHandler(this.selecionar_boleta);
            // 
            // lblBoletas
            // 
            this.lblBoletas.AutoSize = true;
            this.lblBoletas.Location = new System.Drawing.Point(9, 97);
            this.lblBoletas.Name = "lblBoletas";
            this.lblBoletas.Size = new System.Drawing.Size(42, 13);
            this.lblBoletas.TabIndex = 3;
            this.lblBoletas.Text = "Boletas";
            // 
            // bmenu_servicios
            // 
            this.bmenu_servicios.Location = new System.Drawing.Point(154, 25);
            this.bmenu_servicios.Name = "bmenu_servicios";
            this.bmenu_servicios.Size = new System.Drawing.Size(24, 23);
            this.bmenu_servicios.TabIndex = 5;
            this.bmenu_servicios.Text = ">>";
            this.bmenu_servicios.UseVisualStyleBackColor = true;
            this.bmenu_servicios.Click += new System.EventHandler(this.bmenu_servicios_Click);
            // 
            // select_servicios
            // 
            this.select_servicios.FormattingEnabled = true;
            this.select_servicios.Location = new System.Drawing.Point(12, 26);
            this.select_servicios.Name = "select_servicios";
            this.select_servicios.Size = new System.Drawing.Size(136, 21);
            this.select_servicios.TabIndex = 0;
            this.select_servicios.Text = "Seleccionar...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servicio:";
            // 
            // menu_servicios
            // 
            this.menu_servicios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.menu_servicios.Name = "menu_servicios";
            this.menu_servicios.Size = new System.Drawing.Size(154, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem1.Text = "Nuevo Servicio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Nuevo_Servicio);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.Modificar_Servicio);
            // 
            // bNuevaBoleta
            // 
            this.bNuevaBoleta.Location = new System.Drawing.Point(12, 493);
            this.bNuevaBoleta.Name = "bNuevaBoleta";
            this.bNuevaBoleta.Size = new System.Drawing.Size(136, 23);
            this.bNuevaBoleta.TabIndex = 6;
            this.bNuevaBoleta.Text = "Adjuntar Boleta";
            this.bNuevaBoleta.UseVisualStyleBackColor = true;
            this.bNuevaBoleta.Click += new System.EventHandler(this.nueva_boleta);
            // 
            // bCargarBoletas
            // 
            this.bCargarBoletas.Location = new System.Drawing.Point(12, 53);
            this.bCargarBoletas.Name = "bCargarBoletas";
            this.bCargarBoletas.Size = new System.Drawing.Size(136, 23);
            this.bCargarBoletas.TabIndex = 7;
            this.bCargarBoletas.Text = "Cargar Boletas";
            this.bCargarBoletas.UseVisualStyleBackColor = true;
            this.bCargarBoletas.Click += new System.EventHandler(this.mostrar_boletas);
            // 
            // pdfBoleta
            // 
            this.pdfBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfBoleta.Location = new System.Drawing.Point(184, 26);
            this.pdfBoleta.MultiPagesThreshold = 60;
            this.pdfBoleta.Name = "pdfBoleta";
            this.pdfBoleta.Size = new System.Drawing.Size(589, 675);
            this.pdfBoleta.TabIndex = 10;
            this.pdfBoleta.Text = "pdfDocumentViewer1";
            this.pdfBoleta.Threshold = 60;
            this.pdfBoleta.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.FitWidth;
            // 
            // pdfComprobante
            // 
            this.pdfComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfComprobante.Location = new System.Drawing.Point(779, 296);
            this.pdfComprobante.MultiPagesThreshold = 60;
            this.pdfComprobante.Name = "pdfComprobante";
            this.pdfComprobante.Size = new System.Drawing.Size(311, 405);
            this.pdfComprobante.TabIndex = 10;
            this.pdfComprobante.Text = "pdfDocumentViewer1";
            this.pdfComprobante.Threshold = 60;
            this.pdfComprobante.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // bEditarBoleta
            // 
            this.bEditarBoleta.Location = new System.Drawing.Point(12, 522);
            this.bEditarBoleta.Name = "bEditarBoleta";
            this.bEditarBoleta.Size = new System.Drawing.Size(136, 23);
            this.bEditarBoleta.TabIndex = 6;
            this.bEditarBoleta.Text = "Modificar Boleta";
            this.bEditarBoleta.UseVisualStyleBackColor = true;
            this.bEditarBoleta.Click += new System.EventHandler(this.editar_boleta);
            // 
            // gbDatosBoleta
            // 
            this.gbDatosBoleta.Controls.Add(this.bEditarComprobante);
            this.gbDatosBoleta.Controls.Add(this.bNuevoComprobante);
            this.gbDatosBoleta.Controls.Add(this.panel2);
            this.gbDatosBoleta.Controls.Add(this.panelVencimiento);
            this.gbDatosBoleta.Controls.Add(this.lblmensaje);
            this.gbDatosBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosBoleta.Location = new System.Drawing.Point(779, 25);
            this.gbDatosBoleta.Name = "gbDatosBoleta";
            this.gbDatosBoleta.Size = new System.Drawing.Size(311, 265);
            this.gbDatosBoleta.TabIndex = 12;
            this.gbDatosBoleta.TabStop = false;
            this.gbDatosBoleta.Text = "dd/mm/yyyy";
            // 
            // bNuevoComprobante
            // 
            this.bNuevoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevoComprobante.Location = new System.Drawing.Point(103, 203);
            this.bNuevoComprobante.Name = "bNuevoComprobante";
            this.bNuevoComprobante.Size = new System.Drawing.Size(106, 43);
            this.bNuevoComprobante.TabIndex = 3;
            this.bNuevoComprobante.Text = "Adjuntar Comprobante";
            this.bNuevoComprobante.UseVisualStyleBackColor = true;
            this.bNuevoComprobante.Click += new System.EventHandler(this.Nuevo_Comprobante);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(24, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 33);
            this.panel2.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(134, 6);
            this.lblTotal.MaximumSize = new System.Drawing.Size(128, 20);
            this.lblTotal.MinimumSize = new System.Drawing.Size(128, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(128, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "-";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // panelVencimiento
            // 
            this.panelVencimiento.BackColor = System.Drawing.SystemColors.Control;
            this.panelVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVencimiento.Controls.Add(this.lblVencimiento);
            this.panelVencimiento.Controls.Add(this.label2);
            this.panelVencimiento.Location = new System.Drawing.Point(24, 49);
            this.panelVencimiento.Name = "panelVencimiento";
            this.panelVencimiento.Size = new System.Drawing.Size(265, 33);
            this.panelVencimiento.TabIndex = 2;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(134, 6);
            this.lblVencimiento.MaximumSize = new System.Drawing.Size(128, 20);
            this.lblVencimiento.MinimumSize = new System.Drawing.Size(128, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(128, 20);
            this.lblVencimiento.TabIndex = 1;
            this.lblVencimiento.Text = "-";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vencimiento:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(24, 129);
            this.lblmensaje.MaximumSize = new System.Drawing.Size(265, 40);
            this.lblmensaje.MinimumSize = new System.Drawing.Size(265, 40);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(265, 40);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "mensajedeestado";
            this.lblmensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bEditarComprobante
            // 
            this.bEditarComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditarComprobante.Location = new System.Drawing.Point(103, 203);
            this.bEditarComprobante.Name = "bEditarComprobante";
            this.bEditarComprobante.Size = new System.Drawing.Size(106, 43);
            this.bEditarComprobante.TabIndex = 3;
            this.bEditarComprobante.Text = "Editar Comprobante";
            this.bEditarComprobante.UseVisualStyleBackColor = true;
            this.bEditarComprobante.Click += new System.EventHandler(this.Editar_Comprobante);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 720);
            this.Controls.Add(this.gbDatosBoleta);
            this.Controls.Add(this.pdfComprobante);
            this.Controls.Add(this.pdfBoleta);
            this.Controls.Add(this.bCargarBoletas);
            this.Controls.Add(this.bEditarBoleta);
            this.Controls.Add(this.bNuevaBoleta);
            this.Controls.Add(this.bmenu_servicios);
            this.Controls.Add(this.lblBoletas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_boletas);
            this.Controls.Add(this.select_servicios);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu_servicios.ResumeLayout(false);
            this.gbDatosBoleta.ResumeLayout(false);
            this.gbDatosBoleta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelVencimiento.ResumeLayout(false);
            this.panelVencimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lista_boletas;
        private System.Windows.Forms.Label lblBoletas;
        private System.Windows.Forms.Button bmenu_servicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menu_servicios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button bNuevaBoleta;
        public System.Windows.Forms.ComboBox select_servicios;
        private System.Windows.Forms.Button bCargarBoletas;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfBoleta;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfComprobante;
        private System.Windows.Forms.Button bEditarBoleta;
        private System.Windows.Forms.GroupBox gbDatosBoleta;
        private System.Windows.Forms.Button bNuevoComprobante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelVencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button bEditarComprobante;
    }
}

