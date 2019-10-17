using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;

namespace ProyectoTorneo
{
    public class ConexionBD 
    {
        public OdbcConnection con { get; set; }

        public ConexionBD()
        {
            System.Configuration.Configuration webConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/ProyectoTorneo");
            System.Configuration.ConnectionStringSettings conString;
            conString = webConfig.ConnectionStrings.ConnectionStrings["BDTorneo"];

            con = new OdbcConnection(conString.ToString());
            con.Open();
        }
    }
}