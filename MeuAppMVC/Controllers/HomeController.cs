using MeuAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuAppMVC.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            HomeModel Home = new HomeModel();

            Home.Nome = "Robson";
            Home.Email = "Robson@gmail.com";

            return View(Home);
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
}