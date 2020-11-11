using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownColorChange
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LT3.Value = "True";
                RT3.Value = "False";
                ddlAvailability3.SelectedIndex = 0;
                ddlAvailability3.ApplyStyle(new Style() { ForeColor = Color.Green });
            }
            LT3.Attributes.CssStyle.Add("color", "green");
            RT3.Attributes.CssStyle.Add("color", "red");
        }

        protected void ddlAvailability_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var value = ddlAvailability3.SelectedValue;
            if (value.ToLower() == "true")
            {
                ddlAvailability3.ApplyStyle(new Style() { ForeColor = Color.Green });
            }
            else
            {
                ddlAvailability3.ApplyStyle(new Style() { ForeColor = Color.Red });
            }
        }
    }
}