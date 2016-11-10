﻿using GenFu;
using Microsoft.AspNetCore.Mvc;
using pugzore.website.Models;

namespace pugzore.website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new { People = A.ListOf<Person>() });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
