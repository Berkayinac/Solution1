using siniflarim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_lul_Click(object sender, EventArgs e)
        {
            Kahve kahve = new Kahve();
            kahve.Id = 1;
            kahve.Adi = "soguk";
            kahve.Fiyat = 50;

            // Session üzerinden veri gönderme
            HttpContext.Current.Session["kahve"] = kahve.Adi;
            HttpContext.Current.Session["check"] = CheckBox1.Checked;

            int urunfiyati = 40;
            if (CheckBox1.Checked == false)
            {

                urunfiyati=urunfiyati - 20;
                //Response.Redirect("WebForm1.aspx");
            }
        }

        protected void btn_hololo_Click(object sender, EventArgs e)
        {

            Kahve kahve = new Kahve();
            kahve.Id = 1;
            kahve.Adi = "soguk";
            kahve.Fiyat = 50;

            // item ekliyor.
            ListBox1.Items.Add("kahve adi:"+kahve.Adi+ " " + "kahve fiyati:" + kahve.Fiyat);
            DropDownList1.Items.Add("kahve adi:" + kahve.Adi + " " + "kahve fiyati:" + kahve.Fiyat);

            //ListBox1.Items.Add(tbx_hololo.Text);
            //DropDownList1.Items.Add(tbx_hololo.Text);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçilen item'ı direkt olarak tbx'e yazıyor.
            tbx_hololo.Text = DropDownList1.SelectedItem.Text;

            //seçildiği anda remove ediyor.
            DropDownList1.Items.Remove(tbx_hololo.Text);


            //seçildiği anda remove ediyor.
           // DropDownList1.Items.Remove(DropDownList1.SelectedItem.Text);
        }
    }
}