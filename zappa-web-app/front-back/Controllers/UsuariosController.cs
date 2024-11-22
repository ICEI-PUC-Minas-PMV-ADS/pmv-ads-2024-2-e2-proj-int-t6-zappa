using front_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace front_back.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(AppDbContext context, ILogger<UsuariosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Action para exibir a lista de usuários
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();
            return View(dados);
        }

        // Action para exibir a página de cadastro de usuário
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Cadastro realizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
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
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);

            if (usuario != null)
            {
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
