using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class IndexController : Controller
    {
        private ILogger<IndexController> _logger;

        public IndexController(ILogger<IndexController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            try{
                // code removed
            }
            catch(NullReferenceException)
            {
                // code removed
            }
            return View();
        }

        public IActionResult AboutUs()
        {
            try{
                // code removed
            }
            catch
            {
                // code removed
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
