using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GestorComprobantes
{
    class CBaseDatos
    {
        /*
        Esta clase se encargara de todo lo que tenga que ver con editar datos en la base
        ya sea dar de lectura, alta, baja o modificar
         */

        private static SQLiteConnection cn;
        string formatofechas = "dd/MM/yyyy"; //las fechas se guardan como strings!!!

        public CBaseDatos()
        {
            CargarBase();
        }

        public void Alta(object obj)
        {
            if(obj is CServicio)
            {
                string consulta = "INSERT INTO SERVICIOS (NOMBRE_EMPRESA,TIPO,PLAZO) VALUES (@nom,@tipo,@plazo)";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", ((CServicio)obj).Nombre);
                cmd.Parameters.AddWithValue("@tipo", ((CServicio)obj).Tipo);
                cmd.Parameters.AddWithValue("@plazo", ((CServicio)obj).Plazo);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if(obj is CBoleta)
            {

                string consulta = "INSERT INTO BOLETAS (MONTO,ID_SERVICIO,FECHA_EMISION,FECHA_VENCIMIENTO,PDF) VALUES (@monto,@id_serv,@fecha,@fechaV,@pdf)";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@monto", ((CBoleta)obj).Monto);
                cmd.Parameters.AddWithValue("@id_serv", ((CBoleta)obj).ID_Servicio);
                cmd.Parameters.AddWithValue("@fecha", ((CBoleta)obj).Fecha_Emision.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@fechaV", ((CBoleta)obj).Fecha_Vencimiento.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@pdf", ((CBoleta)obj).GetPdf());

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if(obj is CComprobante)
            {
                string consulta = "INSERT INTO COMPROBANTES (MONTO,ID_SERVICIO,ID_BOLETA,FECHA_PAGO,PDF) VALUES (@monto,@idserv,@idbol,@fecha,@pdf)";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@monto", ((CComprobante)obj).Monto);
                cmd.Parameters.AddWithValue("@idserv", ((CComprobante)obj).ID_Servicio);
                cmd.Parameters.AddWithValue("@idbol", ((CComprobante)obj).ID_Boleta);
                cmd.Parameters.AddWithValue("@fecha", ((CComprobante)obj).Fecha_Pago.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@pdf", ((CComprobante)obj).GetPDF());

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }


        }
        public void Baja(object obj)
        {
            if (obj is CServicio)
            {
                string consulta = "DELETE FROM SERVICIOS WHERE ID = @id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", ((CServicio)obj).ID);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if (obj is CBoleta)
            {
                string consulta = "DELETE FROM BOLETAS WHERE ID = @id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", ((CBoleta)obj).ID);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if (obj is CComprobante)
            {

            }

        }
        public void Mod(object obj)
        {
            if (obj is CServicio)
            {
                string consulta = "UPDATE SERVICIOS SET NOMBRE_EMPRESA = @nom, TIPO = @tipo, PLAZO = @plazo WHERE ID=@id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@nom", ((CServicio)obj).Nombre);
                cmd.Parameters.AddWithValue("@tipo", ((CServicio)obj).Tipo);
                cmd.Parameters.AddWithValue("@plazo", ((CServicio)obj).Plazo);
                cmd.Parameters.AddWithValue("@id", ((CServicio)obj).ID);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if (obj is CBoleta)
            {
                string consulta = "UPDATE BOLETAS SET MONTO = @monto,ID_SERVICIO = @id_serv,FECHA_EMISION = @fecha,FECHA_VENCIMIENTO = @fechaV,PDF = @pdf WHERE ID=@id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@monto", ((CBoleta)obj).Monto);
                cmd.Parameters.AddWithValue("@id_serv", ((CBoleta)obj).ID_Servicio);
                cmd.Parameters.AddWithValue("@fecha", ((CBoleta)obj).Fecha_Emision.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@fechaV", ((CBoleta)obj).Fecha_Vencimiento.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@pdf", ((CBoleta)obj).GetPdf());
                cmd.Parameters.AddWithValue("@id", ((CBoleta)obj).ID);

                try
                {
                    cn.Open();
                    cmd.ExecuteReader();
                    cn.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if (obj is CComprobante)
            {
                string consulta = "UPDATE COMPROBANTES SET MONTO = @monto,FECHA_EMISION = @fecha,PDF = @pdf WHERE ID=@id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@monto", ((CComprobante)obj).Monto);
                cmd.Parameters.AddWithValue("@fecha", ((CComprobante)obj).Fecha_Pago.ToString(formatofechas));
                cmd.Parameters.AddWithValue("@pdf", ((CComprobante)obj).GetPDF());
                cmd.Parameters.AddWithValue("@id", ((CComprobante)obj).ID);

                try
                {
                    cn.Open();
                    cmd.ExecuteReader();
                    cn.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
        public byte[] GetPDF(object obj)
        {
            byte[] ret = null;
            if (obj is CBoleta)
            {
                string consulta = "SELECT PDF FROM BOLETAS WHERE ID=@id";
                SQLiteCommand cmd = new SQLiteCommand(consulta,cn);
                cmd.Parameters.AddWithValue("@id",((CBoleta)obj).ID);
                try
                {
                    cn.Open();
                    SQLiteDataReader fila = cmd.ExecuteReader();
                    while (fila.Read())
                    {
                        ret = (byte[])fila["PDF"];
                    }
                    cn.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            if(obj is CComprobante)
            {
                string consulta = "SELECT PDF FROM COMPROBANTES WHERE ID=@id";
                SQLiteCommand cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", ((CComprobante)obj).ID);
                try
                {
                    cn.Open();
                    SQLiteDataReader fila = cmd.ExecuteReader();
                    while (fila.Read())
                    {
                        ret = (byte[])fila["PDF"];
                    }
                    cn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return ret;
        }

        public List<CServicio> ListarServicios()
        {
            List<CServicio> listaServicio = new List<CServicio>();
            string consulta = "SELECT * FROM SERVICIOS";
            try
            {
                cn.Open();
                SQLiteCommand ConsultaServicios = new SQLiteCommand(consulta, cn);
                SQLiteDataReader fila = ConsultaServicios.ExecuteReader();

                while (fila.Read())
                {
                    listaServicio.Add(new CServicio(fila["NOMBRE_EMPRESA"].ToString(), (string)fila["TIPO"].ToString(), Convert.ToInt32(fila["ID"]), Convert.ToInt32(fila["PLAZO"])));
                }

                cn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return listaServicio;
        }

        public List<CBoleta> ListarBoletas(int id)
        {
            List<CBoleta> listaBoleta = new List<CBoleta>();
            string consulta = "SELECT ID,MONTO,ID_SERVICIO,FECHA_EMISION,FECHA_VENCIMIENTO FROM BOLETAS WHERE ID_SERVICIO = @id";
            try
            {
                cn.Open();
                SQLiteCommand ConsultaServicios = new SQLiteCommand(consulta, cn);
                ConsultaServicios.Parameters.AddWithValue("@id",id);
                SQLiteDataReader fila = ConsultaServicios.ExecuteReader();

                while (fila.Read())
                {
                    //parsing fecha...   0123456789
                    //                   DD/MM/AAAA

                    string fecha = fila["FECHA_EMISION"].ToString();
                    //                              |               AAAA           |            MM                    |            DD
                    DateTime dtfecha = new DateTime(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

                    //////////////////////////////////////////////////

                    string fechaV = fila["FECHA_VENCIMIENTO"].ToString();
                    //                              |               AAAA           |            MM                     |            DD
                    DateTime dtfechaV = new DateTime(int.Parse(fechaV.Substring(6, 4)), int.Parse(fechaV.Substring(3, 2)), int.Parse(fechaV.Substring(0, 2)));



                    listaBoleta.Add(new CBoleta(Convert.ToInt32(fila["ID"]),
                                                 float.Parse(fila["MONTO"].ToString()),
                                                 Convert.ToInt32(fila["ID_SERVICIO"]),
                                                 dtfecha, dtfechaV)//primero vecha emision desp fecha vencimiento
                                                 /*nopdf*/);
                }
                cn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return listaBoleta;
        }
        public List<CComprobante> ListarComprobantes(int id)
        {
            List<CComprobante> lista = new List<CComprobante>();
            string consulta = "SELECT ID,MONTO,ID_SERVICIO,ID_BOLETA,FECHA_PAGO FROM COMPROBANTES WHERE ID_SERVICIO = @id";
            try
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand(consulta,cn);
                cmd.Parameters.AddWithValue("@id",id);
                SQLiteDataReader fila = cmd.ExecuteReader();
                while (fila.Read())
                {
                    //parsing fecha...   0123456789
                    //                   DD/MM/AAAA

                    string fecha = fila["FECHA_PAGO"].ToString();
                    //                              |               AAAA           |            MM                    |            DD
                    DateTime dtfecha = new DateTime(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

                    lista.Add(new CComprobante(Convert.ToInt32(fila["ID"]),
                                                float.Parse(fila["MONTO"].ToString()),
                                                Convert.ToInt32(fila["ID_SERVICIO"]),
                                                Convert.ToInt32(fila["ID_BOLETA"]),
                                                dtfecha));
                }
                cn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return lista;
        }

        private static bool CargarBase()
        {
            string directorio = @"%userprofile%\Documents\Base De Servicios\";
            string archivo = "baseservicios.db";
            bool fnuevabase = false;

            directorio = Environment.ExpandEnvironmentVariables(directorio);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
                fnuevabase = true;
            }
            else if (!File.Exists(directorio + archivo))
            {
                fnuevabase = true;
            }

            try
            {
                cn = new SQLiteConnection("Data Source=" + directorio + archivo);
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            if (fnuevabase)
            {
                SQLiteCommand tablaservicios = new SQLiteCommand("CREATE TABLE \"SERVICIOS\"(" +
                    "                                  \"ID\" INTEGER NOT NULL UNIQUE," +
                    "                                  \"TIPO\" TEXT," +
                    "                                  \"NOMBRE_EMPRESA\" TEXT," +
                    "                                  \"PLAZO\" INTEGER," +
                    "                                  PRIMARY KEY(\"ID\" AUTOINCREMENT));", cn);
                tablaservicios.ExecuteReader();
                SQLiteCommand tablaboletas = new SQLiteCommand("CREATE TABLE \"BOLETAS\"(" +
                    "                                  \"ID\" INTEGER NOT NULL UNIQUE," +
                    "                                  \"MONTO\" NUMERIC NOT NULL," +
                    "                                  \"ID_SERVICIO\" INTEGER NOT NULL," +
                    "                                  \"FECHA_EMISION\" TEXT NOT NULL," +
                    "                                  \"FECHA_VENCIMIENTO\" TEXT NOT NULL," +
                    "                                  \"PDF\" BLOB NOT NULL," +
                    "                                  PRIMARY KEY(\"ID\" AUTOINCREMENT));", cn);
                tablaboletas.ExecuteReader();
                SQLiteCommand tablacomprobantes = new SQLiteCommand("CREATE TABLE \"COMPROBANTES\"(" +
                    "                                  \"ID\" INTEGER NOT NULL UNIQUE," +
                    "                                  \"MONTO\" NUMERIC NOT NULL," +
                    "                                  \"ID_SERVICIO\" INTEGER NOT NULL," +
                    "                                  \"ID_BOLETA\" INTEGER NOT NULL," +
                    "                                  \"FECHA_PAGO\" TEXT NOT NULL," +
                    "                                  \"PDF\" BLOB NOT NULL," +
                    "                                  PRIMARY KEY(\"ID\" AUTOINCREMENT));", cn);
                tablacomprobantes.ExecuteReader();
            }
            cn.Close();
            return true;

        }
    }
}
