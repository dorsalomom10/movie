<%@ Page Title="סרטי דרמה" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dramapage.aspx.cs" Inherits="mainpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/movies.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 id="title_drama"> סרטי דרמה ישראליים </h3>
    <div class="imgs">
        <a href="yamim_noraim.media.aspx"><img src="img/yamim_noraim.jpg" /></a>
    </div>
    <div class="imgs">
        <a href="asia.aspx"><img src="img/asia.jpg" /></a>
    </div>
    <div class="imgs">
        <a href="aboa.aspx"><img src="img/aboa.jpg" /></a>
    </div>
    <div class="imgs">
        <a href="ahofe_mebagdad.aspx"><img src="img/ahofe_mebagdad.jpg" /></a>
    </div>
    <div class="imgs">
        <a href="milim_nirdafot.aspx"><img src="img/milim_nirdafot.jpg" /></a>
    </div>
    <div class="imgs">
        <a href="bikor_hatizmoret.aspx"><img src="img/bikor_hatizmoret.jpg" /></a>
    </div>

</asp:Content>

