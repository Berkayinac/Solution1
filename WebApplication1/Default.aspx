<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="tbx_lul" runat="server"></asp:TextBox><asp:CheckBox ID="CheckBox1" runat="server" Text="okudum onaylıyorum" />
                        <asp:Button ID="btn_lul" runat="server" Text="Button" OnClick="btn_lul_Click" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></td>
                    <td>
                        <asp:TextBox ID="tbx_hololo" runat="server"></asp:TextBox>
                        <asp:Button ID="btn_hololo" runat="server" Text="Button" OnClick="btn_hololo_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
