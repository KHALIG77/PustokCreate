using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ContactController:Controller
    {
       
            private readonly PustokContext _context;
            public ContactController(PustokContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                return View();
            }
        
    }
}
