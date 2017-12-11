using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInterface
{
    public partial class userSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(Baglanti.BaglantiCumlecigi);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            Guid userID=Guid.NewGuid();
            cmd.CommandText = "insert into [user] (UserID,UserName,FirstName,LastName,CivilizationNumber) values (@userID,@userName,@firstName,@lastName,@civilizationNumber)";

            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName",txtUserName.Text);
            cmd.Parameters.AddWithValue("@firstName",txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName",txtLastName.Text);
            cmd.Parameters.AddWithValue("@civilizationNumber",txtCivilizationNumber.Text);

            Guid passwordID = Guid.NewGuid();

            SqlCommand cmdPass = new SqlCommand();
            cmdPass.Connection =conn;
            cmdPass.CommandText = "insert into [password] (PasswordID,UserId,Password,ISActive) values (@PasswordID,@UserId,@Password,@ISActive)";

            cmdPass.Parameters.AddWithValue("@PasswordID",passwordID);
            cmdPass.Parameters.AddWithValue("@UserId",userID);
            cmdPass.Parameters.AddWithValue("@Password",txtPassword.Text);
            cmdPass.Parameters.AddWithValue("@ISActive",true);

            conn.Open();
            try
            {
                int user = cmd.ExecuteNonQuery();

                if(user==0)
                {
                    throw new Exception();
                }

                int pass=cmdPass.ExecuteNonQuery();

                if (pass == 0)
                {
                    throw new Exception();
                }
                lblState.Text = "Kayıt Başarılı";

            }
            catch (Exception)
            {

                Response.Redirect("userSignUp.aspx");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}