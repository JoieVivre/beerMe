using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace beerMe
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBTN_Click(object sender, EventArgs e)
        {
            string log = emailSigntxt.Text;
            string pass = pwdSigntxt.Text;

            if (userType.Checked)
            {
                if (pass == "admin")
                {

                    try
                    {
                        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("SELECT pwd FROM Users WHERE email = '" + log + "'");
                        cmd.Connection = connection;
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        string pwdL = "";
                        while (reader.Read())
                        {
                            pwdL = reader["pwd"].ToString().Trim();
                        }

                        if (pass == pwdL)
                        {
                            Session["email"] = log;
                            Response.Redirect("admin.aspx");
                        }

                        connection.Close();
                    }

                    catch (Exception err)
                    {
                        Response.Write(err.Message);

                    }

                }

                else {
                    try
                    {
                        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("SELECT pwd FROM Users WHERE email = '" + log + "'");

                        cmd.Connection = connection;
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        string pwdL = "";
                        while (reader.Read())
                        {
                            pwdL = reader["pwd"].ToString().Trim();
                        }

                        if (pass == pwdL)
                        {
                            Session["email"] = log;
                            Response.Redirect("users.aspx");
                        }

                        connection.Close();
                    }

                    catch (Exception err)
                    {
                        Response.Write(err.Message);

                    }
                }
            }
    
            else if(supplierType.Checked)
            {
                try
                {
                    SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("SELECT pwd FROM Suppliers WHERE email = '" + log + "'");

                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    string pwdL = "";
                    while (reader.Read())
                    {
                        pwdL = reader["pwd"].ToString().Trim();
                    }

                    if (pass == pwdL)
                    {
                        Session["email"] = log;
                        Response.Redirect("suppliers.aspx");
                    }

                    connection.Close();
                }

                catch (Exception err)
                {
                    Response.Write(err.Message);

                }
            }
        }
    }
}