using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kermesse_Proyect.Models;
using Kermesse_Proyect.Controllers;

namespace Kermesse_Proyect.Filters
{
    public class VerificarSession : ActionFilterAttribute
    {
        private Usuario oUsuario;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUsuario = (Usuario)HttpContext.Current.Session["User"];
                if (oUsuario == null)
                {
                    if (filterContext.Controller is AccesoController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Acceso/Login");
                    }
                }
            }
            catch(Exception)
            {
                filterContext.Result = new RedirectResult("~/Acceso/Login");
            }
        }
    }
}