using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorComprobantes
{
    public class CBoleta
    { 
        int id;
        float monto;
        int id_servicio;
        DateTime fecha_emision;
        DateTime fecha_vencimiento;
        byte[] pdf;

        public CBoleta(int id, float monto, int id_servicio, DateTime fecha,DateTime vencimiento)//para leer
        {
            this.id = id;
            this.monto = monto;
            this.id_servicio = id_servicio;
            this.fecha_emision = fecha;
            this.fecha_vencimiento = vencimiento;
            this.pdf = null;
        }
        public CBoleta(float monto, int id_servicio, DateTime fecha, DateTime vencimiento, byte[] pdf)//para crear nueva
        {
            this.monto = monto;
            this.id_servicio = id_servicio;
            this.fecha_emision = fecha;
            this.fecha_vencimiento = vencimiento;
            this.pdf = pdf;
        }

        public void SetPDF(byte[] pdfin)
        {
            this.pdf = pdfin;
        }
        public void SetMonto(float n)
        {
            this.monto = n;
        }
        public void SetServicio(int id)
        {
            this.id_servicio = id;
        }
        public void SetEmision(DateTime dd)
        {
            this.fecha_emision = dd;
        }
        public void SetVencimiento(DateTime dd)
        {
            this.fecha_vencimiento = dd;
        }
        public byte[] GetPdf()
        {
            if (this.pdf == null)
                return CMain.Base.GetPDF(this);
            else
                return this.pdf;
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
        public DateTime Fecha_Emision
        {
            get { return this.fecha_emision; }
        }
        public DateTime Fecha_Vencimiento
        {
            get { return this.fecha_vencimiento; }
        }
    }

}
