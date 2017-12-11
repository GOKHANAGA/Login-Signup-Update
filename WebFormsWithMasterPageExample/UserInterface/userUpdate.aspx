<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userUpdate.aspx.cs" Inherits="UserInterface.userUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="form-group">
        <label for="inputEmail3" class="col-sm-2 control-label">User Name</label>
        <div class="col-sm-5">
            <%-- <input type="email" class="form-control" id="inputEmail3" placeholder="Email" />--%>
            <asp:TextBox ID="txtUserName" class="form-control" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
        <div class="col-sm-5">
            <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password"/>--%>
            <asp:TextBox ID="txtOldPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label for="inputPassword3" class="col-sm-2 control-label">New Password</label>
        <div class="col-sm-5">
            <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password"/>--%>
            <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label for="inputPassword3" class="col-sm-2 control-label">Password Again</label>
        <div class="col-sm-5">
            <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password"/>--%>
            <asp:TextBox ID="txtPasswordAgain" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <%--  <button type="submit" class="btn btn-default">Sign in</button> --%>
            <asp:Button ID="btnUpdate" class="btn btn-default" runat="server" Text="Sign Up" OnClick="btnUpdate_Click" />
        </div>

    </div>


</asp:Content>
