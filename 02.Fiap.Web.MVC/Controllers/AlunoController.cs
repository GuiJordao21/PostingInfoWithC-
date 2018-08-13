using _02.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.Web.MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            //Retornar valores para a tela
            ViewBag.churros = aluno.Nome;
            TempData["msg"] = "Aluno cadastrado";
            return View(aluno);
            //return Content("Nome: " + aluno.Nome + "Rm: " + aluno.Rm + "Turma: " + aluno.Turma);
        }
    }
}