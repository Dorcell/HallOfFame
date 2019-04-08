using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private EFDBContext _context;

        public HomeController(EFDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeModel _model = new HomeModel() { HelloMessage = "Hello" };
            List<Directory> _dirs = _context.Directory.Include(x=>x.Materials).ToList();
            return View(_dirs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
