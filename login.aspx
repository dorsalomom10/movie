<%@ Page Title="עמוד כניסה" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/loginstyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <form id="form_login" action="" method="post" runat="server">
		<h1 id="login"> כניסה למערכת  </h1>
        <table id ="tbl_login">
			<tr>
				<td>
					<input type ="text" placeholder="שם משתמש" id="u_name" class="u_name" runat ="server"/>
				</td>
			</tr>
			<tr>
				<td>
					<input type ="password" placeholder="סיסמא" id="pass"  class="pass" runat ="server"/>
				</td>
			</tr>
			<tr>
				<td>
					<input type="checkbox" runat ="server" id ="coo" />
					 <label for ="coo">זכור אותי</label>
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<input type="submit"class="button" value="היכנס" />
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<a href ="register.aspx"> <h6 id="register"> אני רוצה להירשם </h6> </a>
				</td>
			</tr>
		</table>
		<h4 id="msg" class="msg" runat="server"></h4>
    </form>
</asp:Content>

