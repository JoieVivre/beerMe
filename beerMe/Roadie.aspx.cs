using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace beerMe
{
    public partial class Roadie : System.Web.UI.Page
    {
        double totalRatings;
        double totalNumRaters;
        double currentRating;
        String updatedRating;
        String updatedNumRaters;

        protected void Page_Load(object sender, EventArgs e)
        {
            RoadieInfoTable.Visible = true;
            ButtonRatingAdded.Visible = false;

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Beer WHERE name= 'Roadie'");

            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalRatings = Int32.Parse(reader["rating"].ToString());
                    totalNumRaters = Int32.Parse(reader["numUsersRated"].ToString());

                    TableRow row = new TableRow();

                    TableCell cellBrand = new TableCell();
                    TableCell cellABV = new TableCell();
                    TableCell cellType = new TableCell();
                    TableCell cellVolume = new TableCell();
                    TableCell cellContainer = new TableCell();
                    TableCell cellTotalRating = new TableCell();
                    TableCell cellNumRaters = new TableCell();
                    TableCell cellAvgRating = new TableCell();

                    cellBrand.Text = reader["brand"].ToString();
                    cellABV.Text = reader["ABV"].ToString();
                    cellType.Text = reader["type"].ToString();
                    cellVolume.Text = reader["volume"].ToString();
                    cellContainer.Text = reader["container"].ToString();
                    cellTotalRating.Text = reader["rating"].ToString();
                    cellNumRaters.Text = reader["numUsersRated"].ToString();

                    currentRating = totalRatings / totalNumRaters;
                    cellAvgRating.Text = currentRating.ToString();

                    row.Cells.Add(cellBrand);
                    row.Cells.Add(cellABV);
                    row.Cells.Add(cellType);
                    row.Cells.Add(cellVolume);
                    row.Cells.Add(cellContainer);
                    row.Cells.Add(cellTotalRating);
                    row.Cells.Add(cellNumRaters);
                    row.Cells.Add(cellAvgRating);

                    RoadieInfoTable.Rows.Add(row);
                }
                connection.Close();
            }

            catch (Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void ButtonAddRating_Click(object sender, EventArgs e)
        {
            ImageButton1.Visible = true;
            ImageButton2.Visible = true;
            ImageButton3.Visible = true;
            ImageButton4.Visible = true;
            ImageButton5.Visible = true;
        }
        //method called by beer mug images, will pass associated rated to this method
        public void AddRating(int rating)
        {
            totalRatings += rating;
            totalNumRaters++;
            currentRating = totalRatings / totalNumRaters;
            updatedRating = totalRatings.ToString();
            updatedNumRaters = totalNumRaters.ToString();

            SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\beerMeDB.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("UPDATE Beer SET rating ='" + updatedRating + "', numUsersRated='" + updatedNumRaters + "' WHERE name= 'Roadie'");

            cmd.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ButtonRatingAdded.Visible = true;
                ButtonRatingAdded.Text = "Your rating has been added!";
                connection.Close();
            }

            catch (Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            AddRating(1);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            AddRating(2);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            AddRating(3);
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            AddRating(4);
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            AddRating(5);
        }
    }



}