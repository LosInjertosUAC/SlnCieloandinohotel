using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//BUFFER DE MAMORIA

namespace CapaNegocio.Interfaces
{
    interface IUsuario
    {
        bool Agregar(String Usuario, String Contraseña);
    }
}
