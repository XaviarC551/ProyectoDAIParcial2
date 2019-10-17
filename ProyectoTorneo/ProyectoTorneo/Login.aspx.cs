using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ProyectoTorneo
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(DropDownListTorneos.Items.Count == 0)
            {
                OdbcConnection con = new ConexionBD().con;
                String queryTorneos = "select cTorneo, nombre from torneo";

                OdbcCommand comando = new OdbcCommand(queryTorneos, con);
                OdbcDataReader lector = comando.ExecuteReader();

                DropDownListTorneos.DataSource = lector;
                DropDownListTorneos.DataTextField = "nombre";
                DropDownListTorneos.DataValueField = "cTorneo";
                DropDownListTorneos.DataBind();
            }
        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registra.aspx");
            Session.Abandon();
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            int llavePrimaria;
            String cTorneo = DropDownListTorneos.SelectedValue;
            String nombreTorneo = DropDownListTorneos.SelectedItem.ToString();

            String query = "select cUsuario,username,contrasena from usuario where username=? and contrasena=?";
            OdbcCommand comando = new OdbcCommand(query, con);
            comando.Parameters.AddWithValue("usuario", TextBoxUsuario.Text);
            comando.Parameters.AddWithValue("contrasena", TextBoxPassword.Text);

            OdbcDataReader lector = comando.ExecuteReader();

            if(lector.HasRows)
            {
                lector.Read();
                llavePrimaria = lector.GetInt32(0);

                String updateQuery = "update usuario set cTorneo=? where cUsuario=?";

                OdbcConnection con1 = new ConexionBD().con;
                OdbcCommand comando1 = new OdbcCommand(updateQuery, con1);
                comando1.Parameters.AddWithValue("cTorneo", cTorneo);
                comando1.Parameters.AddWithValue("llavePrimaria", llavePrimaria);

                comando1.ExecuteNonQuery();

                Session.Add("cTorneo", cTorneo);
                Session.Add("nombreTorneo", nombreTorneo);
                Response.Redirect("LoadingTorneo.aspx");
            }
            else
            {
                if(CheckBoxEsEspectador.Checked)
                {
                    Session.Add("cTorneo", cTorneo);
                    Response.Redirect("LoadingTorneo.aspx");
                }
                LabelDatosCorrectos.Text = "Datos incorrectos.";
                TextBoxUsuario.Text = "";
                TextBoxPassword.Text = "";
                Session.Abandon();
            }

            
        }

        protected void ButtonRegistrarTorneo_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistraTorneo.aspx");
            Session.Abandon();
        }
    }
}