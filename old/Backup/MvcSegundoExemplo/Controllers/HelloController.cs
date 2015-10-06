using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSegundoExemplo.Models;

namespace MvcSegundoExemplo.Controllers
{
    public class HelloController : Controller
    {

        public ActionResult Index()
        {
            var aluno = RetornarAlunos().First();

            return View(aluno);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult InserirComRedirect()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
                return View("Resultado", aluno);
            return View(aluno);
        }

        [HttpPost]
        public ActionResult InserirComRedirect(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                TempData["mensagem"] = "Sucesso";
                return RedirectToAction("RelacaoAlunosComRedirect", aluno);
            }
            return View(aluno);
        }

        public ActionResult RelacaoAlunosComRedirect(Aluno aluno)
        {
            return View(aluno);
        }

        public ActionResult InserirAjax()
        {
            return View();
        }

        public ActionResult RetornarDados()
        {
            ViewData.Add("curso", new Curso
                                         {
                                             NomeCurso = "Matematica",
                                             TotalSemestres = 8
                                         });

            ViewBag.Curso = new Curso
                                {
                                    NomeCurso = "Portugues",
                                    TotalSemestres = 6
                                };

            TempData["Curso"] = new Curso
            {
                NomeCurso = "Geografia",
                TotalSemestres = 5
            };

            return View();
        }



        public ActionResult RelacaoAlunos()
        {
            return View();
        }

        public ActionResult RelacaoAlunosAjax()
        {
            return View();
        }

        public ActionResult ListarAlunos()
        {
            return View(RetornarAlunos().ToList());
        }

        public PartialViewResult inserirAlunoAjax(Aluno aluno)
        {
            System.Threading.Thread.Sleep(2000);
            return PartialView("_ResultadoInsercaoAluno", aluno);
        }

        public PartialViewResult ListarAlunosAjax()
        {
            System.Threading.Thread.Sleep(2000);
            return PartialView("_ResultadoAlunos", RetornarAlunos().ToList());
        }


        private IQueryable<Aluno> RetornarAlunos()
        {
            var alunosList = new List<Aluno>
                                 {
                                     new Aluno
                                         {
                                             Cidade = "Fortaleza",
                                             Idade = 30,
                                             Nome = "João"
                                         },
                                         new Aluno
                                         {
                                             Cidade = "Rio de Janeiro",
                                             Idade = 26,
                                             Nome = "Mariana"
                                         },
                                 };
            return alunosList.AsQueryable();
        }

    }
}
