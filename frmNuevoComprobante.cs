using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GestorComprobantes
{
    public partial class frmNuevoComprobante : Form
    {
        CBoleta boleta;
        CComprobante cmod;
        string pathpdf;
        char punto = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ElementAt(0);
        public frmNuevoComprobante(CBoleta B)
        {
            InitializeComponent();
            this.boleta = B;
        }
        public frmNuevoComprobante(CBoleta B,CComprobante C)
        {
            InitializeComponent();
            this.boleta = B;
            this.cmod = C;
        }

        private void frmNuevoComprobante_Load(object sender, EventArgs e)
        {
            string texto = "Boleta: "+boleta.Fecha_Emision.ToString("dd/MM/yyyy")+" | Servicio: "
                +frmMain.listaServicio.Find(x => x.ID == boleta.ID_Servicio).Nombre;
            this.lblmain.Text = texto;

            if (cmod==null)
            {
                //no edito
                this.Text = "Adjuntar Comprobante";
                this.lblArchivo.Visible = true;
                this.lblExtraerPDF.Visible = false;

                this.bEliminar.Enabled = false;

                this.Size = new Size(236,264); //def 294

            }
            if (cmod != null)
            {
                //edito
                this.Text = "Editar Comprobante";
                this.lblArchivo.Visible = false;
                this.lblExtraerPDF.Visible = true;
                this.bBuscarPDF.Text = "Adjuntar Nuevo";

                this.bEliminar.Enabled = true;

                this.montoin.Text = cmod.Monto.ToString();
                this.fechain.Value = cmod.Fecha_Pago;
            }
        }

        private void montoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != punto)
            {
                e.Handled = true;
            }
            if (e.KeyChar == punto && (sender as TextBox).Text.IndexOf(punto) > -1)
            {
                e.Handled = true;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (this.montoin.Text.Length == 0)
            {
                error.SetError(montoin, "Establezca un monto");
                return;
            }
            float monto = float.Parse(this.montoin.Text);
            if (monto < 0)
            {
                error.SetError(montoin, "El monto no puede ser negativo");
                return;
            }

            if (fechain.Value < boleta.Fecha_Emision)
            {
                error.SetError(fechain,"La fecha especificada no puede ser menor a la fecha de emision de la boleta");
                return;
            }
            DateTime fecha = fechain.Value;

            byte[] pdf = null;

            if (pathpdf == null && cmod == null)
            {
                lblArchivo.ForeColor = Color.Red;
                return;
            }
            else if (pathpdf != null && cmod == null)
            {
                pdf = File.ReadAllBytes(pathpdf);
            }
            else if (pathpdf != null && cmod != null)
            {
                pdf = File.ReadAllBytes(pathpdf);
            }

            if (cmod == null)
            {
                CMain.Base.Alta(new CComprobante(monto,boleta.ID_Servicio,boleta.ID,fecha,pdf));
            }
            else
            {
                cmod.SetMonto(monto);
                cmod.SetFecha(fecha);

                if (pathpdf != null)
                {
                    cmod.SetPDF(pdf);
                }

                CMain.Base.Mod(cmod);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void bBuscarPDF_Click(object sender, EventArgs e)
        {
            this.BuscadorPDF.Filter = "Archivos PDF|*.pdf";
            if (this.BuscadorPDF.ShowDialog() == DialogResult.OK)
            {
                pathpdf = BuscadorPDF.FileName;
                this.lblArchivo.Text = Path.GetFileName(pathpdf);
            }
        }
    }
}
