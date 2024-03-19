using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSZI2v2
{
    public partial class RSZI2v2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (`firstname`, `lastname`) VALUES (@name, @lastname);", db.getConnect());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameBox.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = SurnameBox.Text;

            db.openConnect();

            if(command.ExecuteNonQuery() == 1) 
            {
                Label1.Text = "OK";
            }
            else
            {
                Label1.Text = "NE OK";
            }

            db.closeConnect();
        }
    }
}