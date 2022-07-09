using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private static NumberViewModel nvm = new NumberViewModel();
        private static double result;
        // Index Page
        public IActionResult Index()
        {
            var numberVm = new NumberViewModel();
            return View(numberVm); // pass an empty model
        }

        // Loaded Page
        public IActionResult Loaded()
        {
            return View(nvm);
        }

        // POST: post the data onto the model and redirects to Loaded Page
        public IActionResult Load(NumberViewModel numViewModel)
        {
            nvm.Number1 = numViewModel.Number1;
            nvm.Number2 = numViewModel.Number2;
            return RedirectToAction(nameof(Loaded));
        }

        // Result Page
        public IActionResult Result()
        {
            ViewData["Result"] = result;
            return View();
        }

        public IActionResult addition()
        {
            result = nvm.Number1 + nvm.Number2;
            return RedirectToAction(nameof(Result));
  
        }
        public IActionResult subtraction(double num1, double num2)
        {
            result = nvm.Number1 - nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
        public IActionResult multiplication(double num1, double num2)
        {
            result = nvm.Number1 * nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
        public IActionResult division(double num1, double num2)
        {
            result = nvm.Number1 / nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
    }
}

