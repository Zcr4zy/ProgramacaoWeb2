using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Produto> _produtos;
    private List<Categoria> categorias;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _produtos = GranStore.Models.Produto.GetProdutos();
    }

    public IActionResult Index()
    { 
        return View(_produtos);
    }

    public IActionResult Produto(int Id)
    {
        var produto = _produtos.FirstOrDefault(produto => produto.Id == Id);
        return View(produto);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
