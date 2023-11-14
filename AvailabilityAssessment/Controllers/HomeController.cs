using AvailabilityAssessment.Data.Services;
using AvailabilityAssessment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AvailabilityAssessment.Controllers
{
    public class HomeController : Controller
    {
        IEquipmentData db;

        public HomeController()
        {
            db = new InMemoryEquipmentData();
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
}