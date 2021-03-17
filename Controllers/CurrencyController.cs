using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using forex_test_dotnet.Models;

namespace forex_test_dotnet.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CurrencyController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Add()
        {
            return View();
        }

        

    }
}
