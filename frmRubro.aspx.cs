using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using RN;

namespace PresentacionWeb
{
    public partial class frmRubro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            RNRubro ObjRnRubro=new RNRubro ();
            Rubro objRubro=new Rubro ();
            objRubro.id= ObjRnRubro.GenerarId();
            objRubro.NombreRubro = this.txbNombreRubro.Text;
            if (ObjRnRubro.Insertar(objRubro))
            {
                Label2.Text = "Rubro registrado.";
            }
            else
            {
                Label2.Text = "Error en el registro de rubro.";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            RNRubro ObjRnRubro = new RNRubro();
            Int64 idrubro;
            if (Int64.TryParse(this.txbBuscar.Text, out idrubro))
            {
                this.dgwRubro.DataSource = ObjRnRubro.TraerRubro(idrubro);
            }
            else
            {
                this.dgwRubro.DataSource = ObjRnRubro.TraerRubroPorNombre(this.txbNombreRubro.Text);
            }
            dgwRubro.DataBind();
        }
    }
}