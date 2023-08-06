using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Autenticacion.Permisos;

namespace Autenticacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [PermisosRol(Models.Rol.Administrador)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SinPermiso()
        {
            ViewBag.Message = "Usted no cuenta con permisos para ver esta pagina";

            return View();
        }

        public ActionResult CerrarSesion()
        {

            FormsAuthentication.SignOut();
            Session["Usuario"] = null;


            return RedirectToAction("Index", "Acceso");



        }
    }
}