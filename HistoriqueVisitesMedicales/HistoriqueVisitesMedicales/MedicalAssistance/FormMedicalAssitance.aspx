<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMedicalAssitance.aspx.cs" Inherits="HistoriqueVisitesMedicales.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <br />
         <asp:Label ID="lblTitle" runat="server" Text="Titre"></asp:Label>
         <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox><br />
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Label ID="lblAnimal" runat="server" Text="Animal"></asp:Label>
        <ajaxToolkit:ComboBox ID="cbAnimal" runat="server" AutoCompleteMode="Suggest">
        </ajaxToolkit:ComboBox>
         <br />
         <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
         <asp:TextBox ID="tbDate" runat="server"></asp:TextBox>
         <ajaxToolkit:CalendarExtender ID="tbDate_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="tbDate" />
         <br />
         <asp:Label ID="lblDoctor" runat="server" Text="Medicin"></asp:Label>
         <asp:TextBox ID="tbDoctor" runat="server"></asp:TextBox>
         <br />
         <asp:Label ID="lblPlace" runat="server" Text="Place"></asp:Label>
         <asp:TextBox ID="tbPlace" runat="server"></asp:TextBox>
         <br />
         <asp:Label ID="lblComment" runat="server" Text="Commentaire"></asp:Label>
         <asp:TextBox ID="tbComment" runat="server"></asp:TextBox>
         <br />
         <asp:Button ID="btnSend" runat="server" OnClick="Button1_Click" Text="Send" />
    </form>

</body>
</html>
