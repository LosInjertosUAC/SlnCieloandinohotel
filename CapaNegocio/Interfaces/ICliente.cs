using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//BUFFER DE MAMORIA

namespace CapaNegocio.Interfaces
{
    interface ICliente
    {
        bool Agregar(String CodCliente, String APaterno,String AMaterno,String Nombres,String Usuario);
    }
}
