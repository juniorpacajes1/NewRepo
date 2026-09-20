using System;
using System.Linq;
using Datos;

namespace PresentacionWeb
{
    public partial class FrmListadoClientes : System.Web.UI.Page
    {
        // Controles declarados manualmente (no hay designer generado)
        protected global::System.Web.UI.WebControls.GridView gvClientes;
        protected global::System.Web.UI.WebControls.Button btnImprimir;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListado();
            }
        }

        private void CargarListado()
        {
            using (var ctx = new dbDesarrolloSistemaISeptiembre2026Entities())
            {
                var lista = ctx.VClienteGeneral.Where(v => v.TipoCliente == "Natural").ToList();
                this.gvClientes.DataSource = lista;
                this.gvClientes.DataBind();
            }
        }
    }
}
