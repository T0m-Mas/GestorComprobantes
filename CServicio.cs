using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorComprobantes
{
    public class CServicio
    {
        int id;
        string tipo;
        int plazo;
        string nombre_empresa;

        public CServicio(string nombre,string tipo, int id, int plazo) //Constructor para leer
        {
            this.nombre_empresa = nombre;
            this.tipo = tipo;
            this.id = id;
            this.plazo = plazo;
        }
        public CServicio(string nombre, string tipo,int plazo) //Constructor para agregar a la base
        {
            this.nombre_empresa = nombre;
            this.tipo = tipo;
            this.plazo = plazo;
        }

        public void SetNom(string str)
        {
            this.nombre_empresa = str; //VALIDAR
        }
        public void SetTipo(string str)
        {
            this.tipo = str; //VALIDAR
        }
        public void SetPlazo(int n)
        {
            this.plazo = n; //VALIDAR
        }



        public string Nombre
        {
            get { return this.nombre_empresa; }
        }
        public string Tipo
        {
            get { return this.tipo; }
        }
        public int Plazo
        {
            get { return this.plazo; }
        }
        public int ID
        {
            get { return this.id; }
        }

    }
}
