using Microsoft.AspNetCore.Mvc;

namespace ProjetoLogin.Views.Repositories
{
    public class IUsuarioRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
