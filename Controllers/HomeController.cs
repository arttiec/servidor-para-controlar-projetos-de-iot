using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrototypeControlStem.Data;
using PrototypeControlStem.Models;

namespace PrototypeControlStem.Controllers;

public class HomeController : Controller
{
    private readonly DbStemContext _context;

    public HomeController(DbStemContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var prototypes = _context.Prototypes.ToList();

        return View(prototypes);
    }

    public IActionResult Carro(string id) 
    {
        ViewData["topic"] = id;
        
        return View();
    }

    public IActionResult Manipulador(string id)
    {
        ViewData["topic"] = id;
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
