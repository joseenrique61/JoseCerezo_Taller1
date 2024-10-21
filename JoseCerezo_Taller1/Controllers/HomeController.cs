using JoseCerezo_Taller1.Data;
using JoseCerezo_Taller1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JoseCerezo_Taller1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly JoseCerezo_Taller1Context _context;

        public HomeController(ILogger<HomeController> logger, JoseCerezo_Taller1Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeInfoModel homeInfoModel = new()
            {
                Equipos = _context.Equipo.Include(nameof(Equipo.Jugadores)).ToList(),
                Estadios = _context.Estadio.ToList()
            };

            return View(homeInfoModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
