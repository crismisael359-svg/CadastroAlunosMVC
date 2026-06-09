using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunosMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boletim()
        {
            List<string> disciplinas = new List<string>()
            {
                "Matemática",
                "Português",
                "História",
                "Geografia",
                "Inglês"
            };

            List<double> notas = new List<double>()
            {
                8.5,
                6.0,
                9.0,
                4.5,
                7.5
            };

            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}