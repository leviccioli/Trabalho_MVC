using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sua descrição sobre a Página";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos da página";

            return View();
        }
    }
}