using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace beerMe
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //user wants to search beers, listbox1 displays filtering options
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Label1.Visible = true;
            ListBox2.Visible = false;
            SupplierTable1.Visible = false;
            BeerTable1.Visible = false;
            CheckBox1.Checked = false;
            Label2.Visible = false;
        }

        //user can filter beers by variables in listbox
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox2.Visible = false;
            SupplierTable1.Visible = false;
            BeerTable1.Visible = true;

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Beer ORDER BY '" + ListBox1.SelectedValue + "'");

            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    HyperLink link = new HyperLink();

                    TableRow row = new TableRow();
                    TableCell cellName = new TableCell();
                    TableCell cellBrand = new TableCell();
                    TableCell cellABV = new TableCell();
                    TableCell cellType = new TableCell();
                    TableCell cellVolume = new TableCell();
                    TableCell cellContainer = new TableCell();
                    TableCell cellRating = new TableCell();

                    link.ID = "Hyperlink" + reader["name"].ToString();
                    link.NavigateUrl = "~/" + reader["name"].ToString() + ".aspx";
                    link.Text = reader["name"].ToString();

                    cellName.Controls.Add(link);
                    cellBrand.Text = reader["brand"].ToString();
                    cellABV.Text = reader["ABV"].ToString();
                    cellType.Text = reader["type"].ToString();
                    cellVolume.Text = reader["volume"].ToString();
                    cellContainer.Text = reader["container"].ToString();
                    cellRating.Text = reader["rating"].ToString();

                    row.Cells.Add(cellName);
                    row.Cells.Add(cellBrand);
                    row.Cells.Add(cellABV);
                    row.Cells.Add(cellType);
                    row.Cells.Add(cellVolume);
                    row.Cells.Add(cellContainer);
                    row.Cells.Add(cellRating);

                    BeerTable1.Rows.Add(row);
                }

                connection.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }

        }

        //user wants to search suppliers, listbox2 displays filtering options
        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Visible = false;
            ListBox1.Visible = false;
            BeerTable1.Visible = false;
            ListBox2.Visible = true;
            SupplierTable1.Visible = false;
            CheckBox2.Checked = false;
            Label2.Visible = true;
        }

        //user can filter suppliers by variables in listbox2
        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierTable1.Visible = true;

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers ORDER BY '" + ListBox2.SelectedValue + "'");

            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    HyperLink link = new HyperLink();

                    TableRow row = new TableRow();

                    TableCell cellName = new TableCell();
                    TableCell cellType = new TableCell();
                    TableCell cellAddress = new TableCell();
                    TableCell cellPhone = new TableCell();
                    TableCell cellHours = new TableCell();
                    TableCell cellEmail = new TableCell();

                    link.ID = "Hyperlink" + reader["businessName"].ToString();
                    link.NavigateUrl = "~/" + reader["businessName"].ToString() + ".aspx";
                    link.Text = reader["businessName"].ToString();
                    cellName.Controls.Add(link);

                    cellType.Text = reader["businessType"].ToString();
                    cellAddress.Text = reader["address"].ToString();
                    cellPhone.Text = reader["phone"].ToString();
                    cellHours.Text = reader["hours"].ToString();
                    cellEmail.Text = reader["email"].ToString();

                    row.Cells.Add(cellName);
                    row.Cells.Add(cellType);
                    row.Cells.Add(cellAddress);
                    row.Cells.Add(cellPhone);
                    row.Cells.Add(cellHours);
                    row.Cells.Add(cellEmail);

                    SupplierTable1.Rows.Add(row);
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
