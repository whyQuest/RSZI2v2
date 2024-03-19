<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RSZI2v2.aspx.cs" Inherits="RSZI2v2.RSZI2v2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form runat="server">

            <label>Add new person</label> 

            <asp:TextBox ID="NameBox" runat="server" AutoPostBack="true"></asp:TextBox>
           <asp:TextBox ID="SurnameBox" runat="server" AutoPostBack="true"></asp:TextBox>
           <asp:Button ID="Button1" runat="server" Text="Press me" OnClick="Button1_Click" />
      <asp:label ID="Label1" runat="server"></asp:label> 


</form> 
</body>
</html>
