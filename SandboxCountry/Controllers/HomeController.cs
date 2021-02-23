using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SandboxCountry.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace SandboxCountry.Controllers
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

        public IActionResult GetCountryName([FromServices] IConfiguration configuration, CountryData data)
        {
            var connStringBuilder = new NpgsqlConnectionStringBuilder();
            connStringBuilder.Host = configuration.GetValue<string>("CockroachDB:Host");
            connStringBuilder.Port = configuration.GetValue<int>("CockroachDB:Port");
            connStringBuilder.SslMode = SslMode.Disable;
            connStringBuilder.Username = configuration.GetValue<string>("CockroachDB:Username");
            connStringBuilder.Database = configuration.GetValue<string>("CockroachDB:Database");
            string conString = connStringBuilder.ConnectionString;
            
            CountryManager manager = new CountryManager(conString);
            var result = manager.GetCountry(data.CountryCode_Short);

            return View("Index", result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
