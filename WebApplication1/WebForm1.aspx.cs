using siniflarim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Session üzerinden veri çekme
            var kahve = (Kahve)HttpContext.Current.Session["kahve"];

            Label1.Text = kahve.Adi;
            Label2.Text = Convert.ToString(HttpContext.Current.Session["check"]);
        }
    }
}