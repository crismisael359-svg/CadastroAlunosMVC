using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunosMVC.Controllers
{
    public class ProdutoController : Controller
    {
      public IActionResult Index()
{
    List<string> produtos = new List<string>()
    {
        "Notebook",
        "Mouse",
        "Teclado",
        "Monitor",
        "Impressora"
    };

    List<double> precos = new List<double>()
    {
        3500,
        50,
        120,
        900,
        450
    };

    ViewBag.Produtos = produtos;
    ViewBag.Precos = precos;

    return View();
}
    }
}