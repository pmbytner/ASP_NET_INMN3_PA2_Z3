using ASP_NET_INMN3_PA2_Z3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASP_NET_INMN3_PA2_Z3.Controllers;
public class WitajController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Witaj(string imię, int ilość, int ID = 1)
    {
        WitajViewModel modelWidoku = new WitajViewModel() {
            ID = ID,
            Imię = imię,
            Komunikat = $"Witaj {imię}!",
            Ilość = ilość
        };
        return View(modelWidoku);
    }
}
