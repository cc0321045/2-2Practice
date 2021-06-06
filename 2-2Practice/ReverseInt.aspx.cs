using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text = "123456", result = "";
            foreach (char i in text)
            {

                result = i + result;
            }
            Response.Write(result);
        }
    }
}