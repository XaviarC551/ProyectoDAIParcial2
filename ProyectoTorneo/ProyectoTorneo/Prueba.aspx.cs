using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ReporteFlexibleIntento2
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            //select Users.username, score, Tournaments.id_Tournament 
            // from Users, Participants, Tournaments
            //where Users.id_user = Participants.id_user
            //and Participants.id_tournament = Tournaments.id_tournament
            //order by id_Tournament
            String select = "select Users.username, score, Tournaments.id_Tournament ";
            String from = "from Users, Participants, Tournaments ";
            String where = "where Users.id_user = Participants.id_user "
                + "and Participants.id_tournament = Tournaments.id_tournament ";
            String orderBy = "order by id_tournament ";

            String query = select + from + where + orderBy;

            OdbcCommand comando = new OdbcCommand(query, con);
            OdbcDataReader lector = comando.ExecuteReader();

            GridView1.DataSource = lector;
            GridView1.DataBind();
            lector.Close();

            //Cargar checkbox columnas 
            if (CheckBoxList1.Items.Count == 0)
            {
                CheckBoxList1.Items.Add(new ListItem("Usuario", "Users.username"));
                CheckBoxList1.Items.Add(new ListItem("Torneo", "Tournaments.id_Tournament"));
            }

            if (DropDownList1.Items.Count == 0)
            {
                query = "select id_user, username from Users";
                comando = new OdbcCommand(query, con);
                lector = comando.ExecuteReader();
                DropDownList1.DataSource = lector;
                DropDownList1.DataValueField = "id_user";
                DropDownList1.DataTextField = "username";
                DropDownList1.DataBind();
                lector.Close();
            }

            if (DropDownList2.Items.Count == 0)
            {
                query = "select Tournaments.id_Tournament from Tournaments";
                comando = new OdbcCommand(query, con);
                lector = comando.ExecuteReader();
                DropDownList2.DataSource = lector;
                DropDownList2.DataValueField = "id_Tournament";
                DropDownList2.DataTextField = "id_Tournament";
                DropDownList2.DataBind();
                lector.Close();
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new ConexionBD().con;
            String select = "select Users.id_user,";
            String from = "from Users, Participants, Tournaments ";
            String where = "where Users.id_user = Participants.id_user "
                + "and Participants.id_tournament = Tournaments.id_tournament ";
            String orderBy = "order by Tournaments.id_tournament ";

            //Determinar las columnas que se requieren mostrar

            for(int i=0; i<CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    //Pegarle la columna al select...
                    select = select + CheckBoxList1.Items[i].Value.ToString() + ",";
                }
                
            }
            //Quitar la coma y sustituirla por un espacio
            select = select.Substring(0, select.Length - 1) + " ";

            //Procesar los filtros
            if (CheckBox1.Checked == true)
                where = where + "and Users.id_user=? ";

            if (CheckBox2.Checked == true)
                where = where + "and Tournaments.id_tournament=? ";

            String query = select + from + where + orderBy;
            Label1.Text = query;

            OdbcCommand comando = new OdbcCommand(query, con);
            //Cargar parametros al comando
            if (CheckBox1.Checked == true)
                comando.Parameters.AddWithValue("Users.id_user", DropDownList1.SelectedValue);

            if (CheckBox2.Checked == true)
                comando.Parameters.AddWithValue("Tournaments.id_tournament", DropDownList2.SelectedValue);

            OdbcDataReader lector = comando.ExecuteReader();

            GridView1.DataSource = lector;
            GridView1.DataBind();
        }
    }
}