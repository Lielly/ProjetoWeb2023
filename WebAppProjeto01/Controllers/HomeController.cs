using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto01.Models;

namespace WebAppProjeto01.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Home
        public ActionResult Index()
        {
            Home h = new Home();
            h.fabricantes = context.Fabricantes.OrderBy(c => c.Nome);
            h.categorias = context.Categorias.OrderBy(c => c.Nome);
            return View(h);
        }
    }
}