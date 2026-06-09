using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunosMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Christian Misael";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = 1;

            return View();
        }
        public IActionResult Detalhes(int id)
{
    return Content($"Detalhes do aluno ID: {id}");
}
    }
}