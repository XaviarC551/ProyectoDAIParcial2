using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ProyectoTorneo
{
    public partial class Registra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;

            int llavePrimaria = 0;
            String nombre = TextBoxNombre.Text;
            String usuario = TextBoxUsuario.Text;
            String password = TextBoxPassword.Text;
            Random r = new Random();

            Boolean llavePermitida = false;

            // insert into usuario values(cUsuario, nombre, username, password, esEspectador, cTorneo, cPartida)
            String queryAlta = "insert into usuario values(?,?,?,?,null,null,null)";

            while(!llavePermitida)
            {
                llavePrimaria = r.Next(1, 2147483647);
                OdbcCommand comando = new OdbcCommand(queryAlta, con);

                comando.Parameters.AddWithValue("cUsuario", llavePrimaria);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("usuario", usuario);
                comando.Parameters.AddWithValue("contrasena", password);

                try
                {
                    comando.ExecuteNonQuery();
                    llavePermitida = true;
                }
                catch(Exception ex)
                {
                    llavePermitida = false;
                }


            }

            Response.Redirect("Login.aspx");
        }
    }
}