using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Cadastrar(Usuario user)
        {
            return View();
        }
    }
}