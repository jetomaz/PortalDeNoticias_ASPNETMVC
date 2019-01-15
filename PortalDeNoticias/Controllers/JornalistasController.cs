using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class JornalistasController : Controller
    {
        // GET: Jornalistas
        public ActionResult Index()
        {
            var jornalista = new Jornalista();
            return View(jornalista);
        }
    }
}