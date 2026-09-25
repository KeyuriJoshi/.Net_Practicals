using System;

namespace AcademicLeaveManagement
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadLeaveDate();
                LoadRememberedName();
            }
        }

        private void LoadLeaveDate()
        {
            if (Session["LeaveDate"] != null)
            {
                DateTime selectedDate =
                    (DateTime)Session["LeaveDate"];

                txtLeaveDate.Text =
                    selectedDate.ToString("dd-MM-yyyy");
            }
        }

        private void LoadRememberedName()
        {
            if (Request.Cookies["EmployeeName"] != null)
            {
                txtEmployeeName.Text =
                    Request.Cookies["EmployeeName"].Value;

                chkRemember.Checked = true;
            }
        }

        protected void btnSubmit_Click(
            object sender, EventArgs e)
        {
            Page.Validate();

            if (!Page.IsValid)
            {
                lblSuccess.Text = "";
                return;
            }

            if (Session["LeaveDate"] == null)
            {
                lblSuccess.Text =
                    "<span style='color:red'>" +
                    "Please select a date from the Academic Calendar." +
                    "</span>";

                return;
            }

            string employeeName =
                txtEmployeeName.Text.Trim();

            string leaveType =
                ddlLeaveType.SelectedValue;

            string reason =
                txtReason.Text.Trim();

            DateTime leaveDate =
                (DateTime)Session["LeaveDate"];

            Session["EmployeeName"] =
                employeeName;

            if (chkRemember.Checked)
            {
                Response.Cookies["EmployeeName"].Value =
                    employeeName;

                Response.Cookies["EmployeeName"].Expires =
                    DateTime.Now.AddDays(30);
            }

            lblSuccess.Text =
                "Leave application submitted successfully." +
                "<br/>" +
                "Student Name: " + employeeName +
                "<br/>" +
                "Leave Date: " +
                leaveDate.ToString("dd-MM-yyyy") +
                "<br/>" +
                "Leave Type: " + leaveType +
                "<br/>" +
                "Reason: " + reason;
        }
    }
}