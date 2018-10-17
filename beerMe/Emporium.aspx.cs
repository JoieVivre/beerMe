using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace beerMe
{
    public partial class emporium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //checks for supplier being logged in
            if (Session["email"].ToString() == "emporium@gmail.com")
            {
                Label1.Visible = true;
                TBbeerName.Visible = true;
                Label2.Visible = true;
                TBbeerAmount.Visible = true;
                Button2.Visible = true;
            }



        }
        //displays supplier inventory
        protected void Button1_Click(object sender, EventArgs e)
        {
            EmporiumInventoryTable.Visible = true;

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Beer");

            cmd.Connection = connection;

            SqlConnection connection1 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Emporium");

            cmd1.Connection = connection1;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                connection1.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader.Read() && reader1.Read())
                {
                    HyperLink link = new HyperLink();

                    TableRow row = new TableRow();

                    TableCell cellname = new TableCell();
                    TableCell cellbrand = new TableCell();
                    TableCell cellABV = new TableCell();
                    TableCell celltype = new TableCell();
                    TableCell cellvolume = new TableCell();
                    TableCell cellcontainer = new TableCell();
                    TableCell cellamount = new TableCell();

                    link.ID = "Hyperlink" + reader["name"].ToString();
                    link.NavigateUrl = "~/" + reader["name"].ToString() + ".aspx";
                    link.Text = reader["name"].ToString();
                    
                    cellname.Controls.Add(link);
                    cellbrand.Text = reader["brand"].ToString();
                    cellABV.Text = reader["ABV"].ToString();
                    celltype.Text = reader["type"].ToString();
                    cellvolume.Text = reader["volume"].ToString();
                    cellcontainer.Text = reader["container"].ToString();
                    cellamount.Text = reader1["currentAmount"].ToString();

                    row.Cells.Add(cellname);
                    row.Cells.Add(cellbrand);
                    row.Cells.Add(cellABV);
                    row.Cells.Add(celltype);
                    row.Cells.Add(cellvolume);
                    row.Cells.Add(cellcontainer);
                    row.Cells.Add(cellamount);

                    EmporiumInventoryTable.Rows.Add(row);

                }

                connection.Close();
                connection1.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
         
        }
        
        //supplier is updating inventory
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("UPDATE Emporium SET currentAmount='" + TBbeerAmount.Text + "' WHERE name='"+ TBbeerName.Text +"'");

            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                connection.Close();
                Button2.Text = "Inventory has been updated";
            }

            catch (Exception err)
            {
                Response.Write(err.Message);
            }

        }
    }
}