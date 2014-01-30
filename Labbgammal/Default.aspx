<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labb1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Op1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Op1 kan inte vara tom." ControlToValidate="Op1" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Op1 måste innehålla ett heltal." ControlToValidate="Op1" Display="Dynamic" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
      
        <asp:TextBox ID="Op2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="op2 kan inte vara tom." ControlToValidate="Op2" Display="Dynamic">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Op2 måste innehålla ett heltal." ControlToValidate="Op2" Display="Dynamic" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
        <asp:Button ID="Compute" runat="server" Text="En knapp" OnClick="Compute_Click" />
        <asp:Label ID="Result" runat="server" Text="Jovars"></asp:Label>
    </div>
    </form>
</body>
</html>
