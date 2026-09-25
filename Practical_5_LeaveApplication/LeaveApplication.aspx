<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveApplication.aspx.cs"
    Inherits="AcademicLeaveManagement.LeaveApplication" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Leave Application</title>

    <style>
        body {
            font-family: Arial;
            background-color: white;
            margin: 40px;
        }

        .container {
            width: 700px;
            margin: auto;
        }

        h1 {
            font-size: 36px;
            margin-bottom: 30px;
        }

        .row {
            margin-bottom: 18px;
            font-size: 18px;
        }

        .label {
            display: inline-block;
            width: 180px;
            font-weight: bold;
            vertical-align: top;
        }

        .textbox {
            width: 280px;
            height: 30px;
            font-size: 17px;
        }

        .datebox {
            width: 280px;
            height: 30px;
            font-size: 17px;
            background-color: #eeeeee;
        }

        .dropdown {
            width: 290px;
            height: 36px;
            font-size: 17px;
        }

        .reason {
            width: 350px;
            height: 90px;
            font-size: 17px;
        }

        .remember {
            margin-left: 180px;
            font-size: 17px;
        }

        .submit {
            margin-left: 180px;
            padding: 8px 18px;
            font-size: 17px;
        }

        .validation {
            color: red;
            font-size: 14px;
            margin-left: 8px;
        }

        .success {
            display: block;
            margin-top: 30px;
            font-size: 18px;
            line-height: 1.7;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="container">

    <h1>Leave Application</h1>

    <div class="row">

        <asp:Label
            ID="lblEmployeeName"
            runat="server"
            Text="Employee Name:"
            CssClass="label">
        </asp:Label>

        <asp:TextBox
            ID="txtEmployeeName"
            runat="server"
            CssClass="textbox">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="rfvEmployeeName"
            runat="server"
            ControlToValidate="txtEmployeeName"
            ErrorMessage="Required"
            CssClass="validation">
        </asp:RequiredFieldValidator>

    </div>

    <div class="row">

        <asp:Label
            ID="lblLeaveDate"
            runat="server"
            Text="Leave Date:"
            CssClass="label">
        </asp:Label>

        <asp:TextBox
            ID="txtLeaveDate"
            runat="server"
            CssClass="datebox"
            ReadOnly="true">
        </asp:TextBox>

    </div>

    <div class="row">

        <asp:Label
            ID="lblLeaveType"
            runat="server"
            Text="Leave Type:"
            CssClass="label">
        </asp:Label>

        <asp:DropDownList
            ID="ddlLeaveType"
            runat="server"
            CssClass="dropdown">

            <asp:ListItem
                Text="Select Leave Type"
                Value="">
            </asp:ListItem>

            <asp:ListItem
                Text="Medical Leave"
                Value="Medical">
            </asp:ListItem>

            <asp:ListItem
                Text="Casual Leave"
                Value="Casual">
            </asp:ListItem>

            <asp:ListItem
                Text="Academic Leave"
                Value="Academic">
            </asp:ListItem>

            <asp:ListItem
                Text="Emergency Leave"
                Value="Emergency">
            </asp:ListItem>

        </asp:DropDownList>

        <asp:RequiredFieldValidator
            ID="rfvLeaveType"
            runat="server"
            ControlToValidate="ddlLeaveType"
            InitialValue=""
            ErrorMessage="Required"
            CssClass="validation">
        </asp:RequiredFieldValidator>

    </div>

    <div class="row">

        <asp:Label
            ID="lblReason"
            runat="server"
            Text="Reason:"
            CssClass="label">
        </asp:Label>

        <asp:TextBox
            ID="txtReason"
            runat="server"
            TextMode="MultiLine"
            CssClass="reason">
        </asp:TextBox>

        <asp:RequiredFieldValidator
            ID="rfvReason"
            runat="server"
            ControlToValidate="txtReason"
            ErrorMessage="Required"
            CssClass="validation">
        </asp:RequiredFieldValidator>

    </div>

    <div class="row">

        <asp:CheckBox
            ID="chkRemember"
            runat="server"
            Text="Remember my name"
            CssClass="remember">
        </asp:CheckBox>

    </div>

    <div class="row">

        <asp:Button
            ID="btnSubmit"
            runat="server"
            Text="Submit Leave"
            CssClass="submit"
            OnClick="btnSubmit_Click">
        </asp:Button>

    </div>

    <asp:ValidationSummary
        ID="ValidationSummary1"
        runat="server"
        ForeColor="Red"
        HeaderText="Please correct the following:"
        DisplayMode="BulletList">
    </asp:ValidationSummary>

    <asp:Label
        ID="lblSuccess"
        runat="server"
        CssClass="success">
    </asp:Label>

</div>

</form>

</body>
</html>