using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PasswordHub.Models;

namespace PasswordHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Generation()
        {
            ViewData["Message"] = "Generate a Password";
            ViewData["Password"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetPassword()
        {
            string Password = "";
            var letters = new Alphabet();
            var random = new Random();
            for (int j = 0; j < 12; j++)
            {
                var randomIndex = random.Next(0, letters.al.Length);
                Password += letters.al[randomIndex];
            }
            ViewData["Password"] = Password;
            return View("Generation");
        }
    }
}
