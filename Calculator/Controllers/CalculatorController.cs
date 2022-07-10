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
        private static decimal result;
        // Index Page
        public IActionResult Index()
        {
            var numberVm = new NumberViewModel();
            return View(numberVm); // pass an empty model
        }

        
        // POST: post the data onto the model and redirects to corresponding functions
        public IActionResult Load(NumberViewModel numViewModel, string addition, string subtraction, string multiplication, string division)
        {
            nvm.Number1 = numViewModel.Number1;
            nvm.Number2 = numViewModel.Number2;
            if (addition != null)
            {
                return RedirectToAction(nameof(addition));
            }
            if (subtraction != null)
            {
                return RedirectToAction(nameof(subtraction));

            }
            if (multiplication != null)
            {
                return RedirectToAction(nameof(multiplication));

            }
            if (division != null) {
                return RedirectToAction(nameof(division));

            }

            return RedirectToAction(nameof(Index));
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
        public IActionResult subtraction()
        {
            result = nvm.Number1 - nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
        public IActionResult multiplication()
        {
            result = nvm.Number1 * nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
        public IActionResult division()
        {
            result = nvm.Number1 / nvm.Number2;
            return RedirectToAction(nameof(Result));
        }
    }
}

