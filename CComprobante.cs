using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorComprobantes
{
    public class CComprobante
    {
        int id;
        float monto;
        int id_servicio;
        int id_boleta;
        DateTime fecha_pago;
        byte[] pdf;

        public CComprobante(int id, float monto, int id_servicio, int id_boleta, DateTime fecha_pago)//leer
        {
            this.id = id;
            this.monto = monto;
            this.id_servicio = id_servicio;
            this.id_boleta = id_boleta;
            this.fecha_pago = fecha_pago;
            this.pdf = null;
        }
        public CComprobante(float monto, int id_servicio, int id_boleta, DateTime fecha_pago, byte[] pdf)//crear
        {            
            this.monto = monto;
            this.id_servicio = id_servicio;
            this.id_boleta = id_boleta;
            this.fecha_pago = fecha_pago;
            this.pdf = pdf;
        }
        public void SetMonto(float m)
        {
            this.monto = m;
        }
        public void SetFecha(DateTime dd)
        {
            this.fecha_pago = dd;
        }
        public void SetPDF(byte[] pdf)
        {
            this.pdf = pdf;
        }
        public byte[] GetPDF()
        {
            if (this.pdf == null)
                return CMain.Base.GetPDF(this);
            else
                return this.pdf; ;
        }
        public int ID
        {
            get { return this.id; }
        }
        public float Monto
        {
            get { return this.monto; }
        }
        public int ID_Servicio
        {
            get { return this.id_servicio; }
        }
        public int ID_Boleta
        {
            get { return this.id_boleta; }
        }
        public DateTime Fecha_Pago
        {
            get { return this.fecha_pago; }
        }
    }
}
