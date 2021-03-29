using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteCSharp
{
    public partial class Reserva : System.Web.UI.Page
    {
        private srReserva.wsReservaSoapClient servicio;

        private void listar()
        {
            servicio = new srReserva.wsReservaSoapClient();
            gvReserva.DataSource = servicio.Listar();
            gvReserva.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            servicio = new srReserva.wsReservaSoapClient();
            int CodReserva = Convert.ToInt32(txtCodreserva.Text);
            String CodCliente = txtCodcliente.Text.Trim();
            String FechaInicio = txtInicio.Text.Trim();
            String FechaFin = txtFinal.Text.Trim();
            int NrodePersonas = Convert.ToInt32(txtNropersonas.Text);
            String Observaciones = txtObserbaciones.Text.Trim();
            servicio.Agregar(CodReserva, CodCliente, FechaInicio, FechaFin, NrodePersonas, Observaciones);
            listar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio = new srReserva.wsReservaSoapClient();
            int codReserva = Convert.ToInt32(txtCodreserva.Text);
            servicio.Eliminar(codReserva);
            listar();
        }
    }
}