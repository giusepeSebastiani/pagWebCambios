using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PaginaWebCambios
{
    /// <summary>
    /// Descripción breve de WebServiceCambios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceCambios : System.Web.Services.WebService
    {

        private double DtoS = 3.36;
        private double StoD = 0.3;

        
        public WebServiceCambios()
        {
        }

        [WebMethod]
        public double DolarToSoles(double dolar)
        {
            double soles;
            soles = dolar * DtoS;
            return soles;
        }       

        [WebMethod]
        public double SolesToDolar(double soles)
        {
            double dolar;
            dolar = soles * StoD;
            return dolar;
        }

        [WebMethod]
        public void setDtoS(double mon)
        {
            this.DtoS = mon;
        }

        [WebMethod]
        public void setStoD(double mon)
        {
            this.StoD = mon;
        }

    }
}
