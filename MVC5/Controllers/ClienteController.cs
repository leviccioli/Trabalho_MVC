using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using MVC5.Model;

namespace MVC5.Controllers
{
    public class ClienteController : Controller
    {
        Contexto contexto = new Contexto();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(contexto.Cliente.ToList());
        }
    }
}