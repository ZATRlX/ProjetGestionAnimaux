<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListMedicalAssistance.aspx.cs" Inherits="HistoriqueVisitesMedicales.ListMedicalAssistance" %>

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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTitleResult" runat="server"></asp:Label>
            <br />
        <asp:Label ID="lblAnimal" runat="server" Text="Animal"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAnimalResult" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblDateResult" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblDoctor" runat="server" Text="Medicin"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblDoctorResult" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblPlace" runat="server" Text="Endroit"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPlaceResult" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblComment" runat="server" Text="Commentaire"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCommentResult" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <br />
        </div>
    </form>
</body>
</html>
