using front_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace front_back.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context) 
        {
            _context = context;
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
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
            }
            return View(usuario);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) 
                    return NotFound();
            var dados = await _context.Usuarios.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View();
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
            }
            return View();
        }
    }

}
