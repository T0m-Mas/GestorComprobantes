
namespace GestorComprobantes
{
    partial class frmNuevaBoleta
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
            this.select_servicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaIn = new System.Windows.Forms.DateTimePicker();
            this.montoIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBuscarPDF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BuscadorPDF = new System.Windows.Forms.OpenFileDialog();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.fechaVIn = new System.Windows.Forms.DateTimePicker();
            this.bEliminar = new System.Windows.Forms.Button();
            this.lblVerPdf = new System.Windows.Forms.LinkLabel();
            this.ExtractorPDF = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // select_servicio
            // 
            this.select_servicio.FormattingEnabled = true;
            this.select_servicio.Location = new System.Drawing.Point(116, 22);
            this.select_servicio.Name = "select_servicio";
            this.select_servicio.Size = new System.Drawing.Size(100, 21);
            this.select_servicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Emision:";
            // 
            // fechaIn
            // 
            this.fechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIn.Location = new System.Drawing.Point(116, 49);
            this.fechaIn.Name = "fechaIn";
            this.fechaIn.Size = new System.Drawing.Size(100, 20);
            this.fechaIn.TabIndex = 3;
            // 
            // montoIn
            // 
            this.montoIn.Location = new System.Drawing.Point(116, 102);
            this.montoIn.Name = "montoIn";
            this.montoIn.Size = new System.Drawing.Size(100, 20);
            this.montoIn.TabIndex = 4;
            this.montoIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoIn_filtro);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto:";
            // 
            // bBuscarPDF
            // 
            this.bBuscarPDF.Location = new System.Drawing.Point(62, 173);
            this.bBuscarPDF.Name = "bBuscarPDF";
            this.bBuscarPDF.Size = new System.Drawing.Size(117, 23);
            this.bBuscarPDF.TabIndex = 6;
            this.bBuscarPDF.Text = "Adjuntar Archivo";
            this.bBuscarPDF.UseVisualStyleBackColor = true;
            this.bBuscarPDF.Click += new System.EventHandler(this.BuscarPDF);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GuardarBoleta);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(48, 147);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(146, 13);
            this.lblArchivo.TabIndex = 8;
            this.lblArchivo.Text = "No se adjunto ningun archivo";
            this.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Vencimiento:";
            // 
            // fechaVIn
            // 
            this.fechaVIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVIn.Location = new System.Drawing.Point(116, 75);
            this.fechaVIn.Name = "fechaVIn";
            this.fechaVIn.Size = new System.Drawing.Size(100, 20);
            this.fechaVIn.TabIndex = 3;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(10, 242);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(218, 23);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.EliminarBoleta);
            // 
            // lblVerPdf
            // 
            this.lblVerPdf.AutoSize = true;
            this.lblVerPdf.Location = new System.Drawing.Point(61, 147);
            this.lblVerPdf.Name = "lblVerPdf";
            this.lblVerPdf.Size = new System.Drawing.Size(118, 13);
            this.lblVerPdf.TabIndex = 9;
            this.lblVerPdf.TabStop = true;
            this.lblVerPdf.Text = "Extraer Archivo Adjunto";
            this.lblVerPdf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVerPdf.Visible = false;
            this.lblVerPdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVerPdf_LinkClicked);
            // 
            // frmNuevaBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 272);
            this.Controls.Add(this.lblVerPdf);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bBuscarPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montoIn);
            this.Controls.Add(this.fechaVIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_servicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevaBoleta";
            this.Text = "frmNuevaBoleta";
            this.Load += new System.EventHandler(this.frmNuevaBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaIn;
        private System.Windows.Forms.TextBox montoIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBuscarPDF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog BuscadorPDF;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DateTimePicker fechaVIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.LinkLabel lblVerPdf;
        private System.Windows.Forms.SaveFileDialog ExtractorPDF;
    }
}