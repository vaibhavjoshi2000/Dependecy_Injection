using Dependency_Injection_ASP.NetCore.Models;
using Dependency_Injection_ASP.NetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection_ASP.NetCore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEmailSenderService _service;
        public HomeController(IEmailSenderService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            _service.SendEmail("Email Send");
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
