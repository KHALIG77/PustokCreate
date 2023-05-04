using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

            private readonly PustokContext _context;
            public HomeController(PustokContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                return View();
            }

    }
}