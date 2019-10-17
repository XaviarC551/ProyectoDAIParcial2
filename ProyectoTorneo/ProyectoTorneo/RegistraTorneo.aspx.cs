using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ProyectoTorneo
{
    public partial class RegistraTorneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrarTorneo_Click(object sender, EventArgs e)
        {

            String nombreTorneo = TextBox1.Text;
            int claveTorneo = 0;
            Random r = new Random();
            Boolean claveValida = false;

            OdbcConnection con = new ConexionBD().con;

            // insert into torneo values(1,'hola', null, 1);
            String query = "insert into torneo values(?,?,null,1)";

            

            while(!claveValida)
            {
                claveTorneo = r.Next(1, 2147483647);
                OdbcCommand comando = new OdbcCommand(query, con);
                comando.Parameters.AddWithValue("cTorneo", claveTorneo);
                comando.Parameters.AddWithValue("nombreTorneo", nombreTorneo);

                try
                {
                    comando.ExecuteNonQuery();
                    claveValida = true;

                }
                catch(Exception ex)
                {
                    claveValida = false;
                }

            }
            Response.Redirect("Login.aspx");
        }
    }
}