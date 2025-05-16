using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Juego()
        {
            /*La palabra parcialmente descubierta (con guiones bajos en las letras aún no acertadas).
            Las letras ya utilizadas.*/ 
            int intentos=0;
            intentos=palabra.intentos.Count;
            foreach(char letra in palabra.intentos)
            Console.WriteLine(letra);
             return View("Juego");
        }
   
}

