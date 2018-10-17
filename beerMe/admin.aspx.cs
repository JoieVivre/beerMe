using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace beerMe
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addUserBTN_Click(object sender, EventArgs e)
        {
            string u_ID = userID_txt.Text;
            string u_fName = fName_txt.Text;
            string u_lName = lName_txt.Text;
            string u_dob = dob_txt.Text;
            string u_phone = phone_txt.Text;
            string u_email = email_txt.Text;
            string u_pwd = pwd_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(fName, lName, dob, phone, email, pwd) VALUES('" + u_fName + "', '" + u_lName + "', '" + u_dob + "', '" + u_phone + "', '" + u_email + "', '" + u_pwd + "')");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                addMessage.Visible = true;
            }
            catch (Exception err)
            {
                addMessage.Text = err.Message;
                addMessage.Visible = true;

            }

        }

        protected void deleteUserBTN_Click(object sender, EventArgs e)
        {
            string u_ID = userID_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE userID = '" + u_ID + "'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                deleteMessage.Visible = true;
            }
            catch (Exception err)
            {
                deleteMessage.Text = err.Message;
                deleteMessage.Visible = true;

            }
        }

        protected void updateUserBTN_Click(object sender, EventArgs e)
        {
            string u_ID = userID_txt.Text;
            string u_fName = fName_txt.Text;
            string u_lName = lName_txt.Text;
            string u_dob = dob_txt.Text;
            string u_phone = phone_txt.Text;
            string u_email = email_txt.Text;
            string u_pwd = pwd_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Users SET fName = '" + u_fName + "', lName = '" + u_lName + "', dob =  " + u_dob + ", phone = '" + u_phone + "', email = '" + u_email + "', pwd = '" + u_pwd + "' WHERE userID = '"+ u_ID +"'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                updateMessage.Visible = true;
            }
            catch (Exception err)
            {
                updateMessage.Text = err.Message;
                updateMessage.Visible = true;

            }
        }

        protected void addSupplierBTN_Click(object sender, EventArgs e)
        {
            string sName = businessName_txt.Text;
            string sType = businessType_ddl.SelectedItem.Text;
            string sAddress = address_txt.Text;
            string sPhone = supplierPhone_txt.Text;
            string sHours = hours_txt.Text;
            string sEmail = supplierEmail_txt.Text;
            string sPWD = supplierPwd_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers(businessName, businessType, address, phone, hours, email, pwd) VALUES('" + sName + "', '" + sType + "', '" + sAddress + "', '" + sPhone + "', '" + sHours + "','" + sEmail + "', '" + sPWD + "')");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                supplierAddMessage.Visible = true;
            }
            catch(Exception err)
            {
                supplierAddMessage.Text = err.Message;
                supplierAddMessage.Visible = true;

            }
        }

        protected void deleteSupplierBTN_Click(object sender, EventArgs e)
        {
            string sID = supplierID_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE suppliersID = '" + sID + "'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                supplierDeleteMessage.Visible = true;
            }
            catch(Exception err)
            {
                supplierDeleteMessage.Text = err.Message;
                supplierDeleteMessage.Visible = true;
            }
        }

        protected void updateSupplierBTN_Click(object sender, EventArgs e)
        {
            string sID = supplierID_txt.Text;
            string sName = businessName_txt.Text;
            string sType = businessType_ddl.SelectedItem.Text;
            string sAddress = address_txt.Text;
            string sPhone = supplierPhone_txt.Text;
            string sHours = hours_txt.Text;
            string sEmail = supplierEmail_txt.Text;
            string sPWD = supplierPwd_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Suppliers SET businessName = '" + sName + "', businessType = '" + sType + "', address =  '" + sAddress + "', phone = '" + sPhone + "', email = '" + sEmail + "', pwd = '" + sPWD + "' WHERE suppliersID = '" + sID + "'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                supplierUpdateMessage.Visible = true;
            }
            catch(Exception err)
            {
                supplierUpdateMessage.Text = err.Message;
                supplierUpdateMessage.Visible = true;

            }



        }

        protected void addBeerBTN_Click(object sender, EventArgs e)
        {
            string bName = beerName_txt.Text;
            string bBrand = beerBrand_txt.Text;
            string bABV = beerABV_txt.Text;
            string bType = beerType_txt.Text;
            string bVolume = beerVolume_txt.Text;
            string bContain = beerContainer_txt.Text;
            string bPPU = beerPPU_txt.Text;
            string bRating = beerRating_ddl.SelectedItem.Text;
            string bNumUsersRated = usersVoted_ddl.SelectedItem.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Beer(name, brand, ABV, type, volume, container, PPU, rating, numUsersRated) VALUES('" + bName + "', '" + bBrand + "', '" + bABV + "', '" + bType + "', '" + bVolume + "', '" + bContain + "', '" + bPPU + "', '" + bRating + "', '" + bNumUsersRated + "')");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                addBeerMessage.Visible = true;

            }
            catch(Exception err)
            {
                addBeerMessage.Text = err.Message;
                addBeerMessage.Visible = true;
            }
        }

        protected void deleteBeerBTN_Click(object sender, EventArgs e)
        {
            string bID = beerID_txt.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM Beer WHERE beerID ='" + bID + "'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                deleteBeerMessage.Visible = true;

            }
            catch(Exception err)
            {
                deleteBeerMessage.Text = err.Message;
                deleteBeerMessage.Visible = true;

            }
        }

        protected void updateBeerBTN_Click(object sender, EventArgs e)
        {
            string bID = beerID_txt.Text;
            string bName = beerName_txt.Text;
            string bBrand = beerBrand_txt.Text;
            string bABV = beerABV_txt.Text;
            string bType = beerType_txt.Text;
            string bVolume = beerVolume_txt.Text;
            string bContain = beerContainer_txt.Text;
            string bPPU = beerPPU_txt.Text;
            string bRating = beerRating_ddl.SelectedItem.Text;
            string bNumUsersRated = usersVoted_ddl.SelectedItem.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\beerMeDB.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Beer SET name = '" + bName + "', brand = '" + bBrand + "', ABV = '" + bABV + "', type = '" + bType + "', volume =  '" + bVolume + "', container = '" + bContain + "', PPU = '" + bPPU + "', rating =  '" + bRating + "', numUsersRated = '" + bNumUsersRated + "'");
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                updateBeerMessage.Visible = true;

            }
            catch (Exception err)
            {
                updateBeerMessage.Text = err.Message;
                updateBeerMessage.Visible = true;
            }
        }
    }
}