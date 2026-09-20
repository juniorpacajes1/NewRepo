using System;
using System.Linq;
using Datos;

namespace PresentacionWeb
{
    public partial class FrmKardexCliente : System.Web.UI.Page
    {
        // Controles declarados manualmente (no hay designer generado)
        protected global::System.Web.UI.WebControls.Label lblInfo;
        protected global::System.Web.UI.WebControls.GridView gvKardex;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                long id = 0;
                long.TryParse(Request.QueryString["id"], out id);
                if (id > 0)
                {
                    CargarKardex(id);
                }
                else
                {
                    lblInfo.Text = "Id de cliente no válido.";
                }
            }
        }

        private void CargarKardex(long idCliente)
        {
            using (var ctx = new dbDesarrolloSistemaISeptiembre2026Entities())
            {
                var cli = ctx.VClienteGeneral.FirstOrDefault(v => v.idcliente == idCliente);
                if (cli != null)
                {
                    lblInfo.Text = string.Format("Cliente: {0} {1} - Documento: {2} - Tel: {3}", cli.NombreCliente, "", cli.DocumentoIdentidad, cli.Telefono);
                    // Placeholder: no hay movimientos en el modelo; dejar grid vacío
                    gvKardex.DataSource = new object[] { };
                    gvKardex.DataBind();
                }
                else
                {
                    lblInfo.Text = "Cliente no encontrado.";
                }
            }
        }
    }
}
