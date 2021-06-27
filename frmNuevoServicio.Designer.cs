
namespace GestorComprobantes
{
    partial class frmNuevoServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plazoIn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.tipoIn = new System.Windows.Forms.ComboBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plazoIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Las boletas llegan cada ";
            // 
            // plazoIn
            // 
            this.plazoIn.Location = new System.Drawing.Point(131, 73);
            this.plazoIn.Name = "plazoIn";
            this.plazoIn.Size = new System.Drawing.Size(37, 20);
            this.plazoIn.TabIndex = 3;
            this.plazoIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtro_plazo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "dias.";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(15, 145);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(183, 26);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // nombreIn
            // 
            this.nombreIn.Location = new System.Drawing.Point(65, 15);
            this.nombreIn.MaxLength = 40;
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(130, 20);
            this.nombreIn.TabIndex = 5;
            // 
            // tipoIn
            // 
            this.tipoIn.FormattingEnabled = true;
            this.tipoIn.Location = new System.Drawing.Point(65, 43);
            this.tipoIn.Name = "tipoIn";
            this.tipoIn.Size = new System.Drawing.Size(130, 21);
            this.tipoIn.TabIndex = 6;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(15, 113);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(183, 26);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.Eliminar_Servicio);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmNuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 183);
            this.Controls.Add(this.tipoIn);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.plazoIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoServicio";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmNuevoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plazoIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown plazoIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.ComboBox tipoIn;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.ErrorProvider error;
    }
}