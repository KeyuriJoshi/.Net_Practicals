<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="AcademicLeaveManagement.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Academic Calendar</title>

    <style>
        body {
            font-family: Arial;
            background-color: white;
            margin: 40px;
        }

        .container {
            width: 600px;
            margin: auto;
        }

        h1 {
            font-size: 32px;
            margin-bottom: 25px;
        }

        .calendar {
            margin-bottom: 15px;
        }

        .message {
            font-size: 18px;
            margin: 15px 0;
        }

        .button {
            padding: 8px 15px;
            font-size: 17px;
            margin-top: 15px;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

<div class="container">

    <h1>Academic Calendar</h1>

    <asp:Calendar
        ID="AcademicCalendar"
        runat="server"
        CssClass="calendar"
        Width="450px"
        Height="300px"
        OnSelectionChanged="AcademicCalendar_SelectionChanged">

        <TitleStyle
            Font-Bold="True"
            Font-Size="Large" />

        <SelectedDayStyle
            BackColor="#3399FF"
            ForeColor="White"
            Font-Bold="True" />

    </asp:Calendar>

    <asp:Label
        ID="lblSelectedDate"
        runat="server"
        CssClass="message"
        Text="Please select a date.">
    </asp:Label>

    <br />

    <asp:Button
        ID="btnApplyLeave"
        runat="server"
        Text="Apply for Leave"
        CssClass="button"
        OnClick="btnApplyLeave_Click">
    </asp:Button>

</div>

</form>

</body>
</html>