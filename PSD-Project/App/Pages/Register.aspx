<%@ Page Language="C#" CodeBehind="Register.aspx.cs" Inherits="PSD_Project.App.Pages.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div style="display: flex; flex-flow: column; gap: 10px">
        <div>
            <asp:Label runat="server" Text="Username"></asp:Label>
            <asp:TextBox runat="server" Text="" ID="UsernameTextBox"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Email"></asp:Label>
            <asp:TextBox runat="server" Text="" ID="EmailTextBox"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Gender"></asp:Label>
            <div>
                <asp:RadioButtonList runat="server" ID="GenderRadioButtons" AutoPostBack="True">
                    <asp:ListItem Text="Female"/>
                    <asp:ListItem Text="Male"/>
                    <asp:ListItem Text="Rather Not Say"/>
                </asp:RadioButtonList>
            </div>
        </div>
        <div>
            <asp:Label runat="server" Text="Password"></asp:Label>
            <asp:TextBox runat="server" TextMode="Password" Text="" ID="PasswordTextBox"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox runat="server" TextMode="Password" Text="" ID="ConfirmPasswordTextBox"></asp:TextBox>
        </div>
        <asp:Label runat="server" ID="SelectedLabel"></asp:Label>
        <asp:Button runat="server" Text="Register" ID="SubmitButton" OnClick="OnSubmitButtonClicked"/>
    </div>
</form>
</body>
</html>