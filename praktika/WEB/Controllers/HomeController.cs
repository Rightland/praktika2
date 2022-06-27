using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using calculate;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
        double firstArgument,
        double secondArgument,
        string operation)
        {
            double result = 0;

            // switch из "фабрики" напрямую.
            switch (operation)
            {
                case "Сложение":
                    var addition = new Plus();
                    result = addition.Calculate(firstArgument, secondArgument);
                    break;

                case "Вычитание":
                    var subtraction = new minus();
                    result = subtraction.Calculate(firstArgument, secondArgument);
                    break;

                case "Умножение":
                    var multiplication = new Multy();
                    result = multiplication.Calculate(firstArgument, secondArgument);
                    break;
                case "Деление":
                    var division = new Div();
                    result = division.Calculate(firstArgument, secondArgument);
                    break;

                case "Степень":
                    var degree = new Square();
                    result = degree.Calculate(firstArgument, secondArgument);
                    break;

                case "Остаток от деления":
                    Remainder remainder = new Remainder();
                    result = remainder.Calculate(firstArgument, secondArgument);
                    ViewBag.Result = result;
                    break;
            }

            ViewBag.Result = result;

            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}