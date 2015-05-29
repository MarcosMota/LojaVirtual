using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Produto
        private ProdutoRepositorio _repositorio;
        public ActionResult Index()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}