<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_30_11_2022_tasks.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 609px; width: 2082px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter Num1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Enter Num2"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <p>
        &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Height="88px" OnClick="Button1_Click" Text="+" Width="147px" />
        <asp:Button ID="Button3" runat="server" Height="88px" OnClick="Button3_Click" Text="*" Width="147px" />
        <p>
            <asp:Button ID="Button2" runat="server" Height="88px" OnClick="Button2_Click" Text="-" Width="147px" />
            <asp:Button ID="Button4" runat="server" Height="88px" OnClick="Button4_Click" Text="/" Width="147px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Height="88px" Text="=" Width="147px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 5px"></asp:TextBox>
        </p>
    </form>
    </body>
</html>
