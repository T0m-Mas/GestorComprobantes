using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorComprobantes
{
    public partial class frmNuevoServicio : Form
    {
        CServicio smod; //placeholder para el servicio a modificar
        public frmNuevoServicio()//constructor para nuevo
        {
            InitializeComponent();
        }
        public frmNuevoServicio(CServicio S) //constructor para modificador
        {
            InitializeComponent();
            this.smod = S;
        }

        private void frmNuevoServicio_Load(object sender, EventArgs e)
        {
            string[] tiposServicios = {"Luz Electrica",
                                       "Agua Potable",
                                       "Gas Natural",
                                       "Cable/Internet",
                                       "Telefonia Movil",
                                       "Inpuesto Inmobiliario",
                                       "Otro",};

            this.tipoIn.DataSource = tiposServicios;
            if (this.smod!=null)//si modifico el selecionado 
            {
                this.Text = smod.Nombre;
                this.nombreIn.Text = smod.Nombre;
                this.plazoIn.Value = smod.Plazo;
                this.tipoIn.SelectedItem = smod.Tipo;
            }
            else//si agrego nuevo
            {
                this.Text = "Nuevo Servicio";
                this.bEliminar.Hide();
                this.bGuardar.Location = bEliminar.Location;

                this.Size = new Size(231, 185); //default 231,222
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombre, tipo;
            int plazo;

            nombre = this.nombreIn.Text;
            if (nombre.Length == 0) 
            {
                error.SetError(nombreIn,"Este Campo no puede estar vacio");
                return;
            }
            nombre = nombre.Replace('\'',' ');

            tipo = this.tipoIn.Text;
            plazo = Convert.ToInt32(this.plazoIn.Value);
            if (plazo < 1)
            {
                error.SetError(plazoIn, "Debe seleccionar un plazo de dias distinto de cero");
                return;
            }

            if (smod == null)
            {
                CMain.Base.Alta(new CServicio(nombre,tipo,plazo));
            }
            else
            {
                smod.SetNom(nombre);
                smod.SetTipo(tipo);
                smod.SetPlazo(plazo);
                CMain.Base.Mod(smod);
            }
            this.DialogResult = DialogResult.OK;

        }         
        

        private void filtro_plazo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void Eliminar_Servicio(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro que desea eliminar el servicio " + smod.Nombre + "?";
            if(MessageBox.Show(mensaje,"Eliminar Servicio", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                CMain.Base.Baja(smod);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
