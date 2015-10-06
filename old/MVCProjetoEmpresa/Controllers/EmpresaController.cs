using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProjetoEmpresa.Models;

namespace MVCProjetoEmpresa.Controllers
{
    public class EmpresaController : Controller
    {
        //
        // GET: /Empresa/
        EmpresaDBContext empresaDbContext = new EmpresaDBContext();

        public ActionResult Index()
        {
            var empresas = empresaDbContext.Empresas.ToList();
            return View(empresas);
        }


        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (empresa.dtFundacao == DateTime.MinValue)
                        empresa.dtFundacao = DateTime.Now;
                    empresaDbContext.Empresas.Add(empresa);
                    empresaDbContext.SaveChanges();
                    return Json(new
                    {
                        Url = Url.Action("Index"),
                        Mensagem = "Empresa Inserida com Sucesso",
                        Titulo = "Sucesso"
                    });
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var empresa = empresaDbContext.Empresas.First(e => e.Id == id);

            empresaDbContext.Empresas.Remove(empresa);
            empresaDbContext.SaveChanges();
            return Json(new
                            {
                                Mensagem = "Empresa excluida com sucesso"
                            });

        }

        public ActionResult Alterar()
        {
            return View();
        }

        public ActionResult Excluir()
        {
            return View();
        }
    }
}
