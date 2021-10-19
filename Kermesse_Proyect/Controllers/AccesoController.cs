using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kermesse_Proyect.Models;

namespace Kermesse_Proyect.Controllers
{
    public class AccesoController : Controller
    {

        private BDKermesseEntities db = new BDKermesseEntities();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Login(string email, string pwd)
        {
            try
            {
                var oUser = (from u in db.Usuario where u.email == email.Trim() && u.pwd == pwd.Trim() select u).FirstOrDefault();
                if(oUser == null)
                {
                    ViewBag.Error = "Usuario o Contraseña Invalida";
                    return View();
                }

                Session["User"] = oUser;

                return RedirectToAction("Index", "Home");
            }
            catch(Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }
    }
}