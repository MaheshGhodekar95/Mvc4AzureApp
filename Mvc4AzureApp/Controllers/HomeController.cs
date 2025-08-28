using Mvc4AzureApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4AzureApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculatorService _calculator;

        public HomeController() : this(new CalculatorService()) { }

        public HomeController(ICalculatorService calculator)
        {
            _calculator = calculator;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to MVC 4.x App!";
            return View();
        }

        public ActionResult Add(int a = 0, int b = 0)
        {
            var result = _calculator.Add(a, b);
            ViewBag.Result = result;
            return View();
        }
    }
}