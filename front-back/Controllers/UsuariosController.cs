using front_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;  // Importar o namespace para ILogger
using Microsoft.AspNetCore.Http;     // Para manipular sessões

namespace front_back.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UsuariosController> _logger;  // Declarar o logger

        public UsuariosController(AppDbContext context, ILogger<UsuariosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Action para exibir a página de login
        public IActionResult Login()
        {
            return View();
        }

        // Action para processar o login (POST)
        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            // Buscar usuário pelo email e senha
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);

            if (usuario != null)
            {
                // Armazenar dados do usuário na sessão
                HttpContext.Session.SetInt32("UserId", usuario.Id);
                HttpContext.Session.SetString("UserName", usuario.Name);

                TempData["SuccessMessage"] = "Login realizado com sucesso!";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Credenciais inválidas.");
                return View();
            }
        }
    }
}
