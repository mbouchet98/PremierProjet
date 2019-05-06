<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mairie.aspx.cs" Inherits="PremierProjet.Mairie1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="CSSCitoyen.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
    <div  runat="server" id="contenu" class="grandeDiv marg">
        <div id="Nom" class='brd'>
            <asp:Label ID="lblMairie" runat="server" Text=""></asp:Label>
        </div>
        <div id="info" runat="server" class='brd'>
            
        </div>
        
    </div >
    <div runat="server" id="mairie" class="grandeDiv">
        <div id="prenom"class='brd'>
            <asp:Label ID="lblMaire" runat="server" Text=""></asp:Label>
        </div>
        <div id ="donner" runat="server" class='brd'>
            
        </div>
      
    </div>
    
    </form>
</body>
</html>
