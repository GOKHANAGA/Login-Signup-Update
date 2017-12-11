<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="UserInterface.userLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
  <div class="form-group">
    <label for="inputEmail3" class="col-sm-2 control-label">User Name</label>
    <div class="col-sm-10">
     <%-- <input type="email" class="form-control" id="inputEmail3" placeholder="Email" />--%>
        <asp:TextBox ID="txtUserName" class="form-control"  runat="server"></asp:TextBox>
    </div>
  </div>
  <div class="form-group">
    <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
    <div class="col-sm-10">
      <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password"/>--%>
        <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
    <%--  <button type="submit" class="btn btn-default">Sign in</button> --%>
        <asp:Button ID="btnLogin" class="btn btn-default" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>
      <div class="form-group">
          <a href="userSignUp.aspx"> <label class="col-sm-2 control-label">Sing Up?</label></a>
    </div>
  </div>

</asp:Content>
