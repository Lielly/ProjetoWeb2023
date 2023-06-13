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
    public ActionResult Index(long? FabricanteId, long? CategoriaId)
    {
        Home h = new Home();
        h.fabricantes = context.Fabricantes.OrderBy(c => c.Nome);
        h.categorias = context.Categorias.OrderBy(c => c.Nome);
        if((FabricanteId != null))
        {
            h.filtro = "Fabricante";
            h.produtos = context.Produtos.Where(p => p.FabricanteId == FabricanteId).OrderBy(c => c.Nome);
        }
        if ((CategoriaId != null))
        {
            h.filtro = "Categoria";
            h.produtos = context.Produtos.Where(p => p.CategoriaId == CategoriaId).OrderBy(c => c.Nome);
        }
        return View(h);
    }
    public ActionResult IndexProdutosFabricante(long FabId)
    {
        Home h = new Home();
        h.fabricantes = context.Fabricantes.OrderBy(c => c.Nome);
        h.categorias = context.Categorias.OrderBy(c => c.Nome);
        h.produtos = context.Produtos.Where(p => p.FabricanteId == FabId).OrderBy(c => c.Nome);

        return View(h);
    }
    public ActionResult IndexProdutosCategoria(long CatId)
    {
        Home h = new Home();
        h.fabricantes = context.Fabricantes.OrderBy(c => c.Nome);
        h.categorias = context.Categorias.OrderBy(c => c.Nome);
        h.produtos = context.Produtos.Where(p => p.CategoriaeId == CatId).OrderBy(c => c.Nome);

        return View(h);
    }
}