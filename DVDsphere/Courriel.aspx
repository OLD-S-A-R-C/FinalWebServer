<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Courriel.aspx.cs" Inherits="Courriel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DVDsphere</title>
    <link rel="stylesheet" href="styleSheet.css"/>
</head>
<body>
    <form id="form" runat="server">
       <header>
          <asp:PlaceHolder id="headerPlaceHolder" runat="server" />   
       </header>
       <asp:PlaceHolder id="dvdSelectionPlaceHolder" runat="server" />   
       <asp:PlaceHolder id="dvdDetailPlaceHolder" runat="server" />  
       <asp:PlaceHolder id="footerPlaceHolder" runat="server" /> 
    </form>
</html>
