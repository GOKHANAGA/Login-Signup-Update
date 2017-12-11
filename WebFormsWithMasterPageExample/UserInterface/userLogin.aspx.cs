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
    public partial class userLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Baglanti.BaglantiCumlecigi);
            SqlCommand cmd = new SqlCommand(@"Select u.UserID,u.UserName From [User] u 
			inner join [Password] p on u.UserID=p.UserID 
            where u.UserName=@userName and p.[Password]=@password and p.IsActive='true'", conn);

            cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
             SqlDataReader dr=cmd.ExecuteReader();
             if (!dr.HasRows)
                 throw new Exception();
             dr.Read();
             Session["userID"]= dr[0];
             Session["userName"] = dr[1];
             Response.Redirect("index.aspx",false);

            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                conn.Close();
                
            }

        }
    }
}