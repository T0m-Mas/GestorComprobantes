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
    public partial class frmNuevaBoleta : Form
    {

        string pathpdf;
        CBoleta bmod;
        char punto = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ElementAt(0);

        public frmNuevaBoleta()
        {
            InitializeComponent();
        }
        public frmNuevaBoleta(CBoleta B)
        {
            InitializeComponent();
            this.bmod = B;
        }

        private void BuscarPDF(object sender, EventArgs e)
        {
            this.BuscadorPDF.Filter = "Archivos PDF|*.pdf";
            if (this.BuscadorPDF.ShowDialog() == DialogResult.OK)
            {
                this.pathpdf = BuscadorPDF.FileName;
                this.lblArchivo.Text = Path.GetFileName(pathpdf);
                if (bmod != null)
                {
                    lblVerPdf.Visible = false;
                    lblArchivo.Visible = true;
                }
            }

        }

        private void GuardarBoleta(object sender, EventArgs e)
        {
            if (this.montoIn.Text.Length == 0)
            {
                error.SetError(montoIn, "Establezca un monto");
                return;
            }
            float monto = float.Parse(this.montoIn.Text);
            if (monto < 0)
            {
                error.SetError(montoIn, "El monto no puede ser negativo");
                return;
            }

            int id_servicio = frmMain.listaServicio.ElementAt(select_servicio.SelectedIndex).ID;

            if(this.fechaIn.Value > DateTime.Now)
            {
                error.SetError(fechaIn, "No se puede establecer una fecha futura");
                return;
            }
            DateTime fecha = this.fechaIn.Value;
            if (this.fechaVIn.Value < this.fechaIn.Value)
            {
                error.SetError(fechaIn, "No se puede establecer una fecha de Vencimiento menor a la fecha de emision");
                return;
            }
            DateTime fechaV = this.fechaVIn.Value;

            byte[] pdf=null;

            if (pathpdf == null && bmod == null)
            {
                lblArchivo.ForeColor = Color.Red;
                return;
            }
            else if(pathpdf!=null && bmod ==null)
            {
                pdf = File.ReadAllBytes(pathpdf);
            }
            else if(pathpdf!=null && bmod != null)
            {
                pdf = File.ReadAllBytes(pathpdf);
            }
            

            if (bmod == null) //si no edito...
            {                
                CMain.Base.Alta(new CBoleta(monto,id_servicio,fecha,fechaV,pdf));                
            }
            else
            {
                if (pathpdf != null)
                {
                    bmod.SetPDF(pdf);
                }
                bmod.SetMonto(monto);
                bmod.SetServicio(id_servicio);
                bmod.SetEmision(fecha);
                bmod.SetVencimiento(fechaV);

                CMain.Base.Mod(bmod);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void frmNuevaBoleta_Load(object sender, EventArgs e)
        {
            foreach(CServicio s in frmMain.listaServicio)
            {
                this.select_servicio.Items.Add(s.Nombre);
            }

            if (bmod != null) // si edito..
            {
                this.select_servicio.SelectedItem = frmMain.listaServicio.Find(x => x.ID == bmod.ID_Servicio).Nombre;
                this.fechaIn.Value = bmod.Fecha_Emision;
                this.fechaVIn.Value = bmod.Fecha_Vencimiento;
                this.montoIn.Text = bmod.Monto.ToString();

                this.lblArchivo.Visible = false;
                this.bBuscarPDF.Text = "Adjuntar Nuevo";
                this.lblVerPdf.Visible = true;
            }
            else//si no edito...
            {
                this.select_servicio.SelectedIndex = 0;
                this.bEliminar.Enabled = false;
                this.Size = new Size(256, 280); //def 256,311
            }
        }

        private void montoIn_filtro(object sender, KeyPressEventArgs e)
        {
            //"filtro" para numeros flotantes (solo para escribirlos)

            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != punto)
            {
                e.Handled = true;
            }
            if (e.KeyChar==punto && (sender as TextBox).Text.IndexOf(punto) > -1)
            {
                e.Handled = true;
            }
        }

        private void lblVerPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ExtractorPDF.Filter = "Archivos PDF|*.pdf";
            if (this.ExtractorPDF.ShowDialog() == DialogResult.OK)
            {
                string path = ExtractorPDF.FileName;
                File.WriteAllBytes(path,bmod.GetPdf());
            }
        }

        private void EliminarBoleta(object sender, EventArgs e)
        {
            string mensaje = "¿Esta Seguro que desea eliminar la boleta emitida el "+this.bmod.Fecha_Emision.ToString("dd/MM/yyyy")+"?";
            if (MessageBox.Show(mensaje,"Eliminar Boleta",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                CMain.Base.Baja(bmod);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
