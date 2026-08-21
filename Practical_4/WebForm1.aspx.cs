using System;
using System.Web.UI.WebControls;

namespace Practical_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (Page.IsValid)
            {
                string events = "";

                foreach (ListItem item in @event.Items)
                {
                    if (item.Selected)
                    {
                        if (events != "")
                        {
                            events += ", ";
                        }

                        events += item.Text;
                    }
                }

                lblResult.Text =
                    "<br/><b>Registration successfully Done!</b><br/><br/>" +
                    "<b>Name:</b> " + txtName.Text + "<br/>" +
                    "<b>Email Id:</b> " + txtEmail.Text + "<br/>" +
                    "<b>Department:</b> " + dept.SelectedItem.Text + "<br/>" +
                    "<b>Class:</b> " + txtClass.Text + "<br/>" +
                    "<b>Enrollment No.:</b> " + txtEn.Text + "<br/>" +
                    "<b>Gr No.:</b> " + txtGr.Text + "<br/>" +
                    "<b>Gender:</b> " + gen.SelectedValue + "<br/>" +
                    "<b>Event:</b> " + events;
            }
        }

        protected void CustomValidator1_ServerValidate(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid = false;

            foreach (ListItem item in @event.Items)
            {
                if (item.Selected)
                {
                    args.IsValid = true;
                    break;
                }
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}