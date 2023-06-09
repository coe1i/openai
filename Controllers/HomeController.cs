﻿using Microsoft.AspNetCore.Mvc;
using openai.Models;
using System.Diagnostics;

namespace openai.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Merch()
        {
            return View();
        }
        public IActionResult Testimonios()
        {
            return View();
        }
        public IActionResult Newsletter()
        {
            return View();
        }
        public IActionResult Imagenes()
        {
            return View();
        }
        
            private static int visitCounter = 0;


            [HttpGet]
            public JsonResult Visit()
            {
                visitCounter++;
                return Json(new { visits = visitCounter });
            }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}