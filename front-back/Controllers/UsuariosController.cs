using front_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;  // Importar o namespace para ILogger

namespace front_back.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UsuariosController> _logger;  // Declarar o logger

        // Injetar o AppDbContext e ILogger
        public UsuariosController(AppDbContext context, ILogger<UsuariosController> logger)
        {
            _context = context;
            _logger = logger;  // Atribuir o logger injetado
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();
            return View(dados);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            // Adicionar o log para verificar os dados recebidos
            _logger.LogInformation("Tentando criar um novo usuário: Nome: {Name}, Email: {Email}, Senha: {Senha}",
                usuario.Name, usuario.Email, usuario.Senha); // Usando ILogger

            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Cadastro realizado com sucesso!";
                return RedirectToAction(nameof(Index)); // Redireciona para a lista de usuários após o cadastro
            }
            return View(usuario); // Se o modelo não for válido, retorna a mesma view com os erros
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.Usuarios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Usuario usuario)
        {
            if (id != usuario.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); // Redirecionar após edição
            }
            return View(usuario); // Retorna a view com erros
        }
    }
}
