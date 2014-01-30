using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labb1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Compute_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var valueText = TextArea1.InnerHtml;

                TextArea1.Disabled = true;

                Compute.CssClass = "remove";

             //   Button buttonClear = new Button();
             //   buttonClear.Text = "Rensa";
            //    Page.Form.Controls.Add(buttonClear);
            //    buttonClear.CssClass = "clearButton";

                Clear.CssClass = "clearButton";
                var numberOfCapitals = Model.TextAnalyzer.GetNumberOfCapitals(valueText);

                Result.Text = "Texten innehåller " + numberOfCapitals.ToString() + " versaler";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
           
            TextArea1.Disabled = false;
            TextArea1.InnerHtml = "";

        }
    }
}