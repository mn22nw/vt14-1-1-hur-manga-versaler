<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labb1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler</title>
    <link href="~/Content/Main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Hur många versaler</h1>
    <form id="form1" runat="server">
    <div>
        
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="validation-summary-errors" />
        <textarea id="TextArea1" cols="20" rows="2"></textarea>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Textfältet får inte vara tomt." ControlToValidate="TextArea1" Display="Dynamic"></asp:RequiredFieldValidator>
      
      
        <asp:Button ID="Compute" runat="server" Text="Beräkna antalet versaler" OnClick="Compute_Click" />
        <asp:Label ID="Result" runat="server" Text="Jovars"></asp:Label>
    </div>
    </form>
</body>
</html>
