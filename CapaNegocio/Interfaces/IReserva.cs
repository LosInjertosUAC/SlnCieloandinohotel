using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//BUFFER DE MAMORIA

namespace CapaNegocio.Interfaces
{
    interface IReserva
    {
        DataSet Listar();
        bool Agregar(int CodReserva, String CodCliente, String FechaInicio, String FechaFin, int NrodePersonas, String Observaciones);
        bool Eliminar(int CodReserva);
    }
}
