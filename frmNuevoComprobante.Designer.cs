
namespace GestorComprobantes
{
    partial class frmNuevoComprobante
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
            this.components = new System.ComponentModel.Container();
            this.bGuardar = new System.Windows.Forms.Button();
            this.lblmain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montoin = new System.Windows.Forms.TextBox();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.bBuscarPDF = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.BuscadorPDF = new System.Windows.Forms.OpenFileDialog();
            this.bEliminar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblExtraerPDF = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(12, 197);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(196, 23);
            this.bGuardar.TabIndex = 0;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Location = new System.Drawing.Point(12, 9);
            this.lblmain.MinimumSize = new System.Drawing.Size(196, 23);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(196, 23);
            this.lblmain.TabIndex = 1;
            this.lblmain.Text = "label1";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Pago:";
            // 
            // montoin
            // 
            this.montoin.Location = new System.Drawing.Point(98, 49);
            this.montoin.Name = "montoin";
            this.montoin.Size = new System.Drawing.Size(95, 20);
            this.montoin.TabIndex = 3;
            this.montoin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoin_KeyPress);
            // 
            // fechain
            // 
            this.fechain.CustomFormat = "dd/MM/yyyy";
            this.fechain.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechain.Location = new System.Drawing.Point(98, 75);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(95, 20);
            this.fechain.TabIndex = 4;
            // 
            // bBuscarPDF
            // 
            this.bBuscarPDF.Location = new System.Drawing.Point(58, 150);
            this.bBuscarPDF.Name = "bBuscarPDF";
            this.bBuscarPDF.Size = new System.Drawing.Size(100, 23);
            this.bBuscarPDF.TabIndex = 5;
            this.bBuscarPDF.Text = "Adjuntar Archivo";
            this.bBuscarPDF.UseVisualStyleBackColor = true;
            this.bBuscarPDF.Click += new System.EventHandler(this.bBuscarPDF_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(12, 120);
            this.lblArchivo.MaximumSize = new System.Drawing.Size(196, 13);
            this.lblArchivo.MinimumSize = new System.Drawing.Size(196, 13);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(196, 13);
            this.lblArchivo.TabIndex = 6;
            this.lblArchivo.Text = "No se adjuntó ningún archivo";
            this.lblArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BuscadorPDF
            // 
            this.BuscadorPDF.FileName = "openFileDialog1";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(12, 225);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(196, 23);
            this.bEliminar.TabIndex = 0;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // lblExtraerPDF
            // 
            this.lblExtraerPDF.AutoSize = true;
            this.lblExtraerPDF.Location = new System.Drawing.Point(55, 120);
            this.lblExtraerPDF.Name = "lblExtraerPDF";
            this.lblExtraerPDF.Size = new System.Drawing.Size(103, 13);
            this.lblExtraerPDF.TabIndex = 7;
            this.lblExtraerPDF.TabStop = true;
            this.lblExtraerPDF.Text = "Extraer PDF Adjunto";
            // 
            // frmNuevoComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 255);
            this.Controls.Add(this.lblExtraerPDF);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.bBuscarPDF);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.montoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoComprobante";
            this.Text = "frmNuevoComprobante";
            this.Load += new System.EventHandler(this.frmNuevoComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montoin;
        private System.Windows.Forms.DateTimePicker fechain;
        private System.Windows.Forms.Button bBuscarPDF;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.OpenFileDialog BuscadorPDF;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.LinkLabel lblExtraerPDF;
    }
}