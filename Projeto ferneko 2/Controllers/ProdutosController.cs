using Microsoft.AspNetCore.Mvc;
using Projeto_ferneko_2.Models;

namespace Projeto_ferneko_2.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly List<Produto> _produtos = new List<Produto>
        {
            new Produto("") { Id = 1, Nome = "Produto 1", Preco = 10.0m },
            new Produto("") { Id = 2, Nome = "Produto 2", Preco = 20.0m },
            new Produto("") { Id = 3, Nome = "Produto 3", Preco = 30.0m }
        };

        // GET: Produtos
        public ActionResult Index()
        {
            return View(_produtos);
        }

        // GET: Produtos/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Produtos/Cadastrar
        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            produto.Id = _produtos.Count + 1;
            _produtos.Add(produto);
            return RedirectToAction("Index");
        }
    }

   
}
