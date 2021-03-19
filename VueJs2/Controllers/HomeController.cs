using Flurl.Http;
using VueJS.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace VueJS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _endPoint;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _endPoint = "https://6053592045e4b300172916de.mockapi.io/User";
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetUser()
        {
            var list = await _endPoint.GetJsonAsync<List<User>>();
            return Json(list);
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
