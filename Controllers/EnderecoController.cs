using Microsoft.AspNetCore.Mvc;
using CadastroAlunosMVC.Models;

namespace CadastroAlunosMVC.Controllers
{
    public class EnderecoController : Controller
    {
        [HttpGet]
        public IActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscar(Endereco endereco)
        {
            return View("Confirmacao", endereco);
        }
    }
}