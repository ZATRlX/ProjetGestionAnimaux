<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="X_133_silvestrge_AddAnimal.Accueil" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ajouter un animal</div>
        Nom<asp:TextBox ID="txtBName" runat="server"></asp:TextBox>
        <br />
        <asp:ScriptManager runat="server" id="ManagerType" />
        Type<ajaxToolkit:ComboBox ID="cmbBType" runat="server">
            <asp:ListItem>Chat</asp:ListItem>
            <asp:ListItem>Chien</asp:ListItem>
            <asp:ListItem>Poisson</asp:ListItem>
        </ajaxToolkit:ComboBox>
        <br />
        Age<asp:TextBox ID="txtBAge" runat="server"></asp:TextBox>
        <br />
        Race<asp:TextBox ID="txtBSpecies" runat="server"></asp:TextBox>
        <br />
        Sexe
        <ajaxToolkit:ComboBox ID="cmbBoxSexe" runat="server">
            <asp:ListItem Value="0">Garçon</asp:ListItem>
            <asp:ListItem Value="1">Fille</asp:ListItem>
        </ajaxToolkit:ComboBox>
        <br />
        Date de naissance<asp:TextBox ID="txtBDate" runat="server"></asp:TextBox>
        <br />
        Nourriture<asp:TextBox ID="txtBFood" runat="server"></asp:TextBox>
        <br />
        
        Vaccins<ajaxToolkit:ComboBox ID="cmbBoxVaccines" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>...</asp:ListItem>
            <asp:ListItem>Ajouter un vaccins</asp:ListItem>
        </ajaxToolkit:ComboBox>
        <br />
        Image<asp:TextBox ID="txtBPath" runat="server"></asp:TextBox>
        <br />
        Poids<asp:TextBox ID="txtBWeight" runat="server"></asp:TextBox>
        <br />
        <br />
        
        Commentaire<br />
        <asp:TextBox ID="txtBoxComment" runat="server" Height="72px" Width="177px"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Ajouter" />
    </form>
</body>
</html>
