using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ProyectoTorneo
{
    public partial class LoadingTorneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["cTorneo"] == null)
            {
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            String cTorneo = Session["cTorneo"].ToString();
            String nombreTorneo = Session["nombreTorneo"].ToString();
            Label1.Text = nombreTorneo;
            
            if(ListBox1.Items.Count == 0)
            {
                OdbcConnection con = new ConexionBD().con;
                String query = "select cUsuario,nombre from usuario where cTorneo = ?";

                OdbcCommand comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("cTorneo", cTorneo);
                OdbcDataReader lector = comando.ExecuteReader();

                ListBox1.DataSource = lector;
                ListBox1.DataTextField = "nombre";
                ListBox1.DataValueField = "cUsuario";
                ListBox1.DataBind();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TorneoActual.aspx");
        }

        protected void ButtonEliminaJugador_Click(object sender, EventArgs e)
        {
            String cUsuarioElim = ListBox1.SelectedValue;
            OdbcConnection con1 = new ConexionBD().con;
            String query = "update usuario set cTorneo = null where cUsuario = ?";

            OdbcCommand comando1 = new OdbcCommand(query, con1);
            comando1.Parameters.AddWithValue("cUsuario", cUsuarioElim);
            comando1.ExecuteNonQuery();
            Response.Redirect("LoadingTorneo.aspx");

        }

        protected void ButtonRegresar_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}