using System;

namespace AcademicLeaveManagement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AcademicCalendar_SelectionChanged(
            object sender, EventArgs e)
        {
            DateTime selectedDate =
                AcademicCalendar.SelectedDate;

            Session["LeaveDate"] = selectedDate;

            lblSelectedDate.Text =
                "Selected Date: " +
                selectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnApplyLeave_Click(
            object sender, EventArgs e)
        {
            if (AcademicCalendar.SelectedDate == DateTime.MinValue)
            {
                lblSelectedDate.Text =
                    "Please select a date first.";

                return;
            }

            Session["LeaveDate"] =
                AcademicCalendar.SelectedDate;

            Response.Redirect("LeaveApplication.aspx");
        }
    }
}