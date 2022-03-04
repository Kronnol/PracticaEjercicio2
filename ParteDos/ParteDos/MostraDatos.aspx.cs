using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParteDos.Clases;
using ParteDos.Modelo;

namespace ParteDos
{
    public partial class MostraDatos : System.Web.UI.Page
    {
        ModeloEmpleado cn = new ModeloEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }
        private void CargaGrid()
        {

            GridView1.DataSource = cn.mostrar();
            GridView1.DataBind();

        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer'");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView1, "select$" + e.Row.RowIndex.ToString()));

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hf_control.Value = Convert.ToString(GridView1.DataKeys[GridView1.SelectedRow.RowIndex].Value);
            Panel1.Visible = true;
            empleado obj = cn.extraerAlumno(Convert.ToInt32(hf_control.Value));
            txtCodigo.Text = Convert.ToString(obj.codigo_empleado);
            txtNombre.Text = obj.Nombre;

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            cn.borrarAlumno(Convert.ToInt32(hf_control.Value));
        }
    }
}