using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWebCambios
{
    public partial class WebForm : System.Web.UI.Page
    {
        private WebServiceCambios sw = new WebServiceCambios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void das(Object sender, EventArgs e)
        {
            
            try
            {
                string var = tb1.Text;
                double a = Double.Parse(var);

                lb1.Text = var + " dolares son " + sw.DolarToSoles(a).ToString() + " Soles";
                tb1.Text = "";
            }
            catch
            {
                lb1.Text = "Ingrese un caracter valido: ";
                tb1.Text = "";
            }

        }


        protected void sad(Object sender, EventArgs e)
        {

            try
            {
                string var = tb1.Text;
                double a = Double.Parse(var);

                lb1.Text = var + " Soles son " + sw.SolesToDolar(a).ToString() + " Dolares";
                tb1.Text = "";
            }
            catch
            {
                lb1.Text = "Ingrese un caracter valido: ";
                tb1.Text = "";
            }

        }





    }
}