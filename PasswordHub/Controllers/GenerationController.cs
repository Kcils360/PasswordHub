using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PasswordHub.Controllers
{
    public class GenerationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Generate a password";
            return View();
        }
    }
}