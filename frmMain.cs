using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.PdfViewer.Forms;

namespace GestorComprobantes
{
    public partial class frmMain : Form
    {
        static public List<CServicio> listaServicio;           //
        static public List<CBoleta> listaBoletas;              // PLACEHOLDERS PARA NO ESTAR TODO EL TIEMPO LEYENDO LA BASE
        static public List<CComprobante> listaComprobante;     //
         public frmMain()
        {
            InitializeComponent();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listaServicio = CMain.Base.ListarServicios();
            Dictionary<int, string> dir = new Dictionary<int, string>();
            this.select_servicios.Items.Clear();
            this.gbDatosBoleta.Text = "";
            this.lblmensaje.Text = "";

            if (listaServicio.Count != 0)
            {

                foreach (CServicio S in listaServicio)
                {
                    this.select_servicios.Items.Add(S.Nombre);
                }
                this.select_servicios.SelectedIndex = 0;

                this.select_servicios.Enabled = true;
                this.lista_boletas.Enabled = true;
                this.bNuevaBoleta.Enabled = true;
                this.bCargarBoletas.Enabled = true;
                this.bEditarBoleta.Enabled = true;
            }
            else
            {
                this.select_servicios.Text = "  ¡Vacio!  ";
                this.select_servicios.Enabled = false;
                this.lista_boletas.Enabled = false;
                this.bNuevaBoleta.Enabled = false;
                this.bCargarBoletas.Enabled = false;
                this.bEditarBoleta.Enabled = false;
            }
        }        

        private void bmenu_servicios_Click(object sender, EventArgs e)
        {
            this.menu_servicios.Show(Cursor.Position);
        }

        private void mostrar_boletas(object sender, EventArgs e)
        {
            //this.lista_boletas.Items.Clear();

            Dictionary<int, string> dir = new Dictionary<int, string>();

            listaBoletas = null;
            listaComprobante = null;
            listaBoletas = CMain.Base.ListarBoletas(listaServicio.ElementAt(select_servicios.SelectedIndex).ID);
            listaComprobante = CMain.Base.ListarComprobantes(listaServicio.ElementAt(select_servicios.SelectedIndex).ID);
            this.lblBoletas.Text = "Boletas de " + listaServicio.ElementAt(select_servicios.SelectedIndex).Nombre;
            try
            {
                if (listaBoletas.Count!=0)
                {
                    this.lista_boletas.Enabled = true;

                    foreach(CBoleta b in listaBoletas)
                    {
                        if (b.Fecha_Vencimiento < DateTime.Now && listaComprobante.Find(x => x.ID_Boleta == b.ID)==null)
                        {
                            //this.lista_boletas.Items.Add(b.Fecha_Emision.ToString("dd/MM/yyyy")+" (!)");
                            dir.Add(b.ID,b.Fecha_Emision.ToString("dd/MM/yyyy")+" (!)");
                        }
                        else
                        {
                            //this.lista_boletas.Items.Add(b.Fecha_Emision.ToString("dd/MM/yyyy"));

                            dir.Add(b.ID, b.Fecha_Emision.ToString("dd/MM/yyyy"));
                        }
                    }
                    this.lista_boletas.DisplayMember = "Value";
                    this.lista_boletas.ValueMember = "Key";
                    this.lista_boletas.DataSource = dir.OrderBy(b => b.Value).ToArray(); //entrego el dir ordenado x fecha (si ordeno con la propiedad de combobox se despelota todo!)

                }
                else
                {
                    this.lista_boletas.Enabled = false;
                    this.lista_boletas.DataSource = null;
                    this.lista_boletas.DisplayMember = null;
                    this.lista_boletas.ValueMember = null;
                    this.lista_boletas.Items.Add("No se encontraron boletas");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void nueva_boleta(object sender, EventArgs e)
        {
            frmNuevaBoleta frm = new frmNuevaBoleta();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                mostrar_boletas(sender, e);
            }
        }

        private void Nuevo_Servicio(object sender, EventArgs e)
        {
            frmNuevoServicio frm = new frmNuevoServicio();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frmMain_Load(sender, e); //recargo el form para que se vean los cambios
            }
        }

        private void Modificar_Servicio(object sender, EventArgs e)
        {
            frmNuevoServicio frm = new frmNuevoServicio(listaServicio.ElementAt(this.select_servicios.SelectedIndex));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frmMain_Load(sender, e); //recargo el form para que se vean los cambios
            }
        }

        private void selecionar_boleta(object sender, EventArgs e)
        {
            //se da cuando se cambia el index de la lista de boletas
            //muestra la boleta seleccionada en el visor del frmMain
            //y sus datos adjuntados
            string formatofechas = "dd/MM/yyyy";

            //mensajes a mostrar....
            string sincomprobante = "Aun no se adjuntó el comprobante";
            string sincomprobantevencido = "Aun no se adjuntó el comprobante\nSe ha superado el vencimiento indicado";
            string pagadoposvencimiento = "La fecha de pago es mayor al vencimiento\nLa boleta podria presentar deuda";
            string pagado = "Comprobante adjuntado";

            if (this.lista_boletas.SelectedItem != null && listaServicio.Count>0)
            {

                CBoleta BolShow = listaBoletas.Find(x => x.ID == (int) lista_boletas.SelectedValue);

                pdfBoleta.CloseDocument();
                pdfBoleta.Update();
                byte[] pdfShow = BolShow.GetPdf();
                MemoryStream streampdf = new MemoryStream(pdfShow);
                pdfBoleta.LoadFromStream(streampdf);

                this.gbDatosBoleta.Text = BolShow.Fecha_Emision.ToString(formatofechas);
                this.lblVencimiento.Text = BolShow.Fecha_Vencimiento.ToString(formatofechas);
                this.lblTotal.Text = BolShow.Monto.ToString();
                this.lblmensaje.Visible = true;

                if (listaComprobante.Find(x => x.ID_Boleta == BolShow.ID) == null)
                {
                    this.bNuevoComprobante.Visible = true;
                    this.bEditarComprobante.Visible = false;

                    if (BolShow.Fecha_Vencimiento < DateTime.Now)
                    {
                        this.lblmensaje.Text = sincomprobantevencido;
                        this.panelVencimiento.BackColor = Color.Salmon;
                    }
                    else
                    {
                        this.lblmensaje.Text = sincomprobante;
                        this.panelVencimiento.BackColor = DefaultBackColor;
                    }

                }
                else
                {
                    this.bNuevoComprobante.Visible = false;
                    this.bEditarComprobante.Visible = true;

                    if (BolShow.Fecha_Vencimiento < listaComprobante.Find(x => x.ID_Boleta == BolShow.ID).Fecha_Pago)
                    {
                        this.lblmensaje.Text = pagadoposvencimiento;
                        this.panelVencimiento.BackColor = Color.Yellow;
                    }
                    else
                    {
                        this.lblmensaje.Text = pagado;
                        this.panelVencimiento.BackColor = DefaultBackColor;
                    }


                }
            }

        }

        private void editar_boleta(object sender, EventArgs e)
        {
            frmNuevaBoleta frm = new frmNuevaBoleta(listaBoletas.Find(x=>x.ID== (int) lista_boletas.SelectedValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                mostrar_boletas(sender, e);
            }
        }

        private void Nuevo_Comprobante(object sender, EventArgs e)
        {
            frmNuevoComprobante frm = new frmNuevoComprobante(listaBoletas.Find(x => x.ID == (int)lista_boletas.SelectedValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                mostrar_boletas(sender, e);
            }
        }
        private void Editar_Comprobante(object sender, EventArgs e)
        {
            frmNuevoComprobante frm = new frmNuevoComprobante(listaBoletas.Find(x => x.ID == (int)lista_boletas.SelectedValue),
                                                              listaComprobante.Find(x=>x.ID_Boleta==(int)lista_boletas.SelectedValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                mostrar_boletas(sender, e);
            }
        }
    }
}
