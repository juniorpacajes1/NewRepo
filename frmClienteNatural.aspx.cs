using RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class frmClienteNatural : System.Web.UI.Page
    {

        private void Cargarcomborubro()
        {
            RNRubro ObjRnRubro=new RNRubro();
            this.cbRubro.DataSource = ObjRnRubro.TraerRubro(0);
            this.cbRubro.DataTextField = "NombreRubro";
            this.cbRubro.DataValueField  = "id";
            this.cbRubro.DataBind();
        }
        private void CargarcomboBarrio()
        {
            RNBarrio ObjRnBarrio = new RNBarrio();
            this.cbBarrio.DataSource = ObjRnBarrio.TraerBarrio(0);
            this.cbBarrio.DataTextField = "NombreBarrio";
            this.cbBarrio.DataValueField = "id";
            this.cbBarrio.DataBind();
        }
        private void CargarcombozonaBarrio2()
        {
            RNBarrio ObjRnBarrio = new RNBarrio();
            this.cbBarrio.DataSource = ObjRnBarrio.TraerBarriozona(0);
            this.cbBarrio.DataTextField = "NombreZonaBarrio";
            this.cbBarrio.DataValueField = "id";
            this.cbBarrio.DataBind();

            this.cbBarrio.Items.Insert(0, new ListItem("-- Seleccione un barrio --", "0"));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargarcomborubro();
                CargarcombozonaBarrio2();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RN.CtrlCliente ctrl = new RN.CtrlCliente();
                Datos.Cliente cliente = new Datos.Cliente();
                Datos.Natural natural = new Datos.Natural();

                long nuevoId = ctrl.GenerarId();
                cliente.id = nuevoId;
                cliente.Direccion = this.txbDireccion.Text;
                cliente.Telefono = this.txbTelefono.Text;

                long idRubro = 0;
                long.TryParse(this.cbRubro.SelectedValue, out idRubro);
                cliente.idRubro = idRubro;

                long idBarrio = 0;
                long.TryParse(this.cbBarrio.SelectedValue, out idBarrio);
                cliente.idBarrio = idBarrio;

                // Nit es opcional
                long nitVal;
                if (long.TryParse(this.txbNit.Text, out nitVal))
                    cliente.Nit = nitVal;
                else
                    cliente.Nit = null;

                // Natural
                natural.id = nuevoId; // llave uno a uno
                natural.NombreCliente = this.txbNombreCliente.Text;
                natural.ApellidoPaterno = this.txbApellidoPaterno.Text;
                natural.ApellidoMaterno = this.txbApellidoMaterno.Text;
                natural.DocumentoIdentidad = this.txbDocumentoIdentidad.Text;
                natural.Genero = this.rbFemenino.Checked ? "Femenino" : (this.rbMasculino.Checked ? "Masculino" : string.Empty);

                DateTime fecha;
                if (DateTime.TryParse(this.txbFechaNacimiento.Text, out fecha))
                    natural.FechaNacimiento = fecha;
                else
                    natural.FechaNacimiento = null;

                bool ok = ctrl.InsertarClienteNatural(cliente, natural);
                if (ok)
                {
                    this.txbid.Text = nuevoId.ToString();
                    // Mostrar notificación sencilla
                    ClientScript.RegisterStartupScript(this.GetType(), "msg", "alert('Cliente natural registrado correctamente.');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "msg", "alert('Error al registrar el cliente natural.');", true);
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "msg", "alert('Error: " + ex.Message.Replace("'", "\\'") + "');", true);
            }
        }
    }
}