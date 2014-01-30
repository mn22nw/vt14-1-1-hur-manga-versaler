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
            var op1 = int.Parse(Op1.Text);
            var op2 = int.Parse(Op2.Text);
            var sum = op1 + op2;

            Result.Text = sum.ToString();

            TextAnalyzer.GetNumberOfCapitals(Result.Text);
           
        }

    }

    public static class TextAnalyzer
    {
        static public int GetNumberOfCapitals(string text)
        {

            int upperCase = 0;

            foreach (char c in text)
            {

                if (Char.IsUpper(c))

                    upperCase += 1;
            }

            return upperCase;
        }
    }
}