using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Regex_Exemple
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEmail_Click(object sender, EventArgs e)
        {
            LblMail.Text = ValidMail(TexttEmail.Text).ToString();
        }
        private bool ValidMail(string adresse)
        {
            Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
            return myRegex.IsMatch(adresse); 
        }
        private bool ValidMat(string matr)
        {
            Regex myRegex = new Regex(@"^[0-9]{2}\-[A-Z]\-[0-9]{6}$");
            return myRegex.IsMatch(matr);
        }

        protected void ButtonMat_Click(object sender, EventArgs e)
        {
            LblMat.Text = ValidMat(TextMat.Text).ToString();

        }
    }
}