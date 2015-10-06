using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;

namespace MVCProjetoEmpresa.Teste
{
    [TestFixture]
    public class EmpresaControllerTest
    {
        [Test]
        public void PodeRetornarParaViewIndexTest()
        {
            //Ambiente
            var empresaController = new MVCProjetoEmpresa.Controllers.EmpresaController();


            //Ação
            var result = empresaController.Index();


            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual("", ((ViewResult)result).ViewName);

        }

        [Test]
        public void PodeRetornarParaViewInserirTest()
        {
            //Ambiente
            var empresaController = new MVCProjetoEmpresa.Controllers.EmpresaController();


            //Ação
            var result = empresaController.Inserir();


            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual("", ((ViewResult)result).ViewName);

        }

        [Test]
        public void PodeRetornarParaViewAlterarTest()
        {
            //Ambiente
            var empresaController = new MVCProjetoEmpresa.Controllers.EmpresaController();


            //Ação
            var result = empresaController.Alterar();


            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual("", ((ViewResult)result).ViewName);

        }

        [Test]
        public void PodeRetornarParaViewExcluirTest()
        {
            //Ambiente
            var empresaController = new MVCProjetoEmpresa.Controllers.EmpresaController();


            //Ação
            var result = empresaController.Excluir();


            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual("", ((ViewResult)result).ViewName);

        }
        
        [Test]
        public void PodeSomarTest()
        {
            //Ambiente
            var primeiroValor = 2;
            var segundoValor = 3;

            //Ação
            var result = Somar(primeiroValor, segundoValor);

            //Assert
            Assert.AreEqual(5, result);
        }




        [Test]
        public void PodeExcluirTest()
        {
            //Ambiente
            var primeiroValor = 2;
            var segundoValor = 3;

            //Ação
            var result = Excluir(primeiroValor, segundoValor);

            //Assert
            Assert.AreEqual(6, result);
        }

        private object Excluir(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }





        private int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
