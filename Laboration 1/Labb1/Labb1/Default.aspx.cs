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



                var numberOfCapitals = Model.TextAnalyzer.GetNumberOfCapitals(valueText);

                Result.Text = numberOfCapitals.ToString();
            }
        }
    }
}