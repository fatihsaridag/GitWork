using GitWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GitWorkContext _context;



        public HomeController(ILogger<HomeController> logger, GitWorkContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserRegister userRegister)
        {
            if (userRegister.FirstName != null && userRegister.LastName != null)
            {

                _context.UserRegisters.Add(userRegister);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userRegister);
        }


        public IActionResult UserList()
        {
            var users = _context.UserRegisters.ToList();
            return View(users);
        }


    }
}