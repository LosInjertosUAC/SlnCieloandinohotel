using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;//LLAMAR A CAPA DATOS

namespace CapaNegocio
{
    public class Cliente : Interfaces.ICliente
    {
        //LLAMAR A LA CAPA DATOS
        private Datos datos = new DatosSQL();
        //PROPIEDAD DE SOLO LECTURA PARA EL PROCEDIMIENTO ALMACENADO
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Agregar(string CodCliente, string APaterno, string AMaterno, string Nombres, string Usuario)
        {
            //TRAER RESULTADO CON CODERROR Y MENSAJE
            DataRow fila = datos.TraerDataRow("spAgregarCliente", CodCliente, APaterno, AMaterno, Nombres, Usuario);
            //TRAER EL COD ERROR Y EL MENSAJE
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
    }
}
