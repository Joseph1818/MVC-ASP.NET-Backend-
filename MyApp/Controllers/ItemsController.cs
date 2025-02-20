using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MyAppContext _context; 
       
        // Getting new context
        public ItemsController(MyAppContext Context)
        {
            //Adding the value of the context
            _context = Context;
        }

        public async Task <IActionResult> Index()
        {   
            var item = await _context.Items.ToListAsync();
            return View(item);
        }
    }
}
  
