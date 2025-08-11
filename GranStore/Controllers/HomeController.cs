using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Eletrônicos";

        Categoria categoria2 = new()
        {
            Id = 2,
            Nome = "Roupas"
        };

        List<Produto> Produtos = new List<Produto>()
        {
            new Produto{
                Id = 1,
                Nome = "Notebook G1",
                Descricao = "Lorem, Ipsum",
                Categoria = categoria,
                QtdeEstoque = 5,
                ValorCusto = 2000,
                ValorVenda = 5500
            },
            new Produto{
                Id = 2,
                Nome = "Camisa do Vasco",
                Descricao = "Camisa do gigante da colina",
                Categoria = categoria2,
                QtdeEstoque = 20,
                ValorCusto = 359,
                ValorVenda = 470
            },
        };
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
