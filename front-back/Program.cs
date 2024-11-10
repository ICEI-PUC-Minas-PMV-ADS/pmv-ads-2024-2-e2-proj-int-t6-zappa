using front_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Configura o contexto do banco de dados com a string de conex�o
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura o logging para permitir visualiza��o no console e Debug
builder.Services.AddLogging(logging =>
{
    logging.ClearProviders();  // Remove provedores antigos de log (se houver)
    logging.AddConsole();      // Adiciona o Console para o log
    logging.AddDebug();        // Adiciona o Debug para o log
    logging.SetMinimumLevel(LogLevel.Debug);  // Garante que logs de n�vel Debug sejam exibidos
});

var app = builder.Build();

// Configura o pipeline de requisi��o HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapeia a rota do controlador
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
