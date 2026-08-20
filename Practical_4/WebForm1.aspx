<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 271px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            width: 271px;
            height: 29px;
        }
        .auto-style6 {
            height: 33px;
        }
        .auto-style7 {
            height: 48px;
        }
        .auto-style8 {
            width: 271px;
            height: 48px;
        }
        .auto-style9 {
            width: 297px;
        }
        .auto-style10 {
            height: 48px;
            width: 297px;
        }
        .auto-style11 {
            height: 29px;
            width: 297px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Event Registration Portal</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ForeColor="Red" ErrorMessage="Please enter your name">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Email Id:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Please enter email Id">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$" ErrorMessage="Enter a valid email address">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="pwd" runat="server" OnTextChanged="TextBox6_TextChanged" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="pwd" ForeColor="Red" ErrorMessage="Please enter password">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Confirm Password:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="cpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cpwd" ErrorMessage="Please enter confirm password " ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwd" ControlToValidate="cpwd" ForeColor="Red" ErrorMessage="Password not match">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Department:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="dept" runat="server">
                        <asp:ListItem Value="0">Select Department</asp:ListItem>
                        <asp:ListItem>CE</asp:ListItem>
                        <asp:ListItem>CSC</asp:ListItem>
                        <asp:ListItem>CSC - AI &amp; ML</asp:ListItem>
                        <asp:ListItem>CSC - AI &amp; DS</asp:ListItem>
                        <asp:ListItem>CSC CS</asp:ListItem>
                        <asp:ListItem>ICT</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dept" ForeColor="Red" InitialValue="0" ErrorMessage="Please select your department">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Class:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtClass" ForeColor="Red" ErrorMessage="Please enter your class">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Enrollnment No.:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEn" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEn" ForeColor="Red" ErrorMessage="Please enter your Enrollment no.">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Gr No.:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtGr" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtGr" ForeColor="Red" ErrorMessage="Please enter your Gr no. ">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Gender:</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="gen" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="gen" ForeColor="Red" ErrorMessage="Please select your gender">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Event:</td>
                <td class="auto-style3">
                    <asp:CheckBoxList ID="event" runat="server">
                        <asp:ListItem>Tech</asp:ListItem>
                        <asp:ListItem>Non-Tech</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please select at least one event" ForeColor="Red" ValidateEmptyText="True">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">
                    <asp:Button ID="regBtn" runat="server" OnClientClick="Registration Done" Text="Register" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please correct the following errors:" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
