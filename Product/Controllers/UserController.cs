using Microsoft.AspNetCore.Mvc;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext dbContext;
        public UserController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var users = dbContext.users.ToList();
            return View();
        }

        public IActionResult Signin()
        {
            User user = new User();
               
            return View(user);
        }

        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the book to DB
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
