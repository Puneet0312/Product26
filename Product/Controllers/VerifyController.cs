using Microsoft.AspNetCore.Mvc;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Controllers
{
    public class VerifyController : Controller
    {
        private ApplicationDbContext dbContext;
        public VerifyController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            var verc = dbContext.VerifyAccount.ToList();
            return View(verc);
        }
    }
}
