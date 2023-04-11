using Microsoft.AspNetCore.Mvc;

namespace MeuProjeto.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly List<Fornecedor> _fornecedores = new List<Fornecedor>
        {
            new Fornecedor { Id = 1, Nome = "Fornecedor 1", Telefone = "1234567890" },
            new Fornecedor { Id = 2, Nome = "Fornecedor 2", Telefone = "0987654321" },
            new Fornecedor { Id = 3, Nome = "Fornecedor 3", Telefone = "5555555555" }
        };

        // GET: Fornecedores
        public ActionResult Index()
        {
            return View(_fornecedores);
        }

        // GET: Fornecedores/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Fornecedores/Cadastrar
        [HttpPost]
        public ActionResult Cadastrar(Fornecedor fornecedor)
        {
            fornecedor.Id = _fornecedores.Count + 1;
            _fornecedores.Add(fornecedor);
            return RedirectToAction("Index");
        }
    }

    internal class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
