﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Autenticacion.Models;
using Autenticacion.Logica;
using System.Web.Security;

namespace Autenticacion.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string correo, string clave)
        {
            Usuarios objeto = new LO_Usuario().EncontrarUsuario(correo, clave);

            if (objeto.Nombres != null)
            {


                FormsAuthentication.SetAuthCookie(objeto.Correo, false);

                Session["Usuario"] = objeto;

                return RedirectToAction("Index", "Home");
            }



            return View();
        }
    }
}