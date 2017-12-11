using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInterface
{
    public partial class userUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(Baglanti.BaglantiCumlecigi);

        public void GetPasswords()
        {
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM [User] WHERE userName=@userName", conn);
            cmd.Parameters.AddWithValue("@userName", txtUserName.Text);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string userID = cmd.ExecuteScalar().ToString();

            conn.Close();


            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "SELECT [Password] FROM [Password] WHERE [Password] = (SELECT [Password] FROM [Password] WHERE UserID=@userID AND IsActive=1) AND [Password]=@oldPassword";
            cmd2.Parameters.AddWithValue("@userID", userID);
            cmd2.Parameters.AddWithValue("@oldPassword", txtOldPassword.Text);
            cmd2.Connection = conn;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string password = cmd2.ExecuteScalar().ToString();
            conn.Close();



            if (txtOldPassword.Text == password)
            {
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "INSERT INTO [Password] (PasswordID,UserID,Password,IsActive) VALUES (@passwordID,@userID,@passWord,@isActive)";
                cmd3.Parameters.AddWithValue("@userID", userID);
                cmd3.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd3.Parameters.AddWithValue("@passwordID", Guid.NewGuid().ToString());
                cmd3.Parameters.AddWithValue("@isActive","True");

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                int effectedRow = cmd3.ExecuteNonQuery();
                txtUserName.Text = effectedRow.ToString();
                conn.Close();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            GetPasswords();
        }
    }
}