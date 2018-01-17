<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListMedicalAssistanceEdit.aspx.cs" Inherits="HistoriqueVisitesMedicales.ListMedicalAssistance" %>

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
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Titre"></asp:Label>
            <asp:TextBox ID="tbTitle" runat="server" Enabled="False"></asp:TextBox><br />
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Label ID="lblAnimal" runat="server" Text="Animal"></asp:Label>
        <ajaxToolkit:ComboBox ID="cbAnimal" runat="server" AutoCompleteMode="Suggest" Enabled="False">
        </ajaxToolkit:ComboBox>
            <br />
            <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            <asp:TextBox ID="tbDate" runat="server" Enabled="False"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="tbDate_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="tbDate" />
            <br />
            <asp:Label ID="lblDoctor" runat="server" Text="Medicin"></asp:Label>
            <asp:TextBox ID="tbDoctor" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblPlace" runat="server" Text="Endroit"></asp:Label>
            <asp:TextBox ID="tbPlace" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblComment" runat="server" Text="Commentaire"></asp:Label>
            <asp:TextBox ID="tbComment" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Enregistrer" />
            <br />
        </div>
    </form>
</body>
</html>
