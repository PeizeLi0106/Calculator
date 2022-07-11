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
        private static decimal number1;
        private static decimal number2;
        private static decimal result;
        private static string errorMessage;
        // Index Page
        public IActionResult Index()
        {
            ViewData["ErrorMessage"] = errorMessage;
            ViewData["Result"] = result;
            ViewData["Number1"] = number1;
            ViewData["Number2"] = number2;
            return View(); // pass an empty model
        }

        
        // POST: post the data onto the model and redirects to corresponding functions
        public IActionResult Load(decimal num1, decimal num2, string addition, string subtraction, string multiplication, string division)
        {
            number1 = num1;
            number2 = num2;
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

        

        public IActionResult addition()
        {
            result = number1 + number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
  
        }
        public IActionResult subtraction()
        {
            result = number1 - number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult multiplication()
        {
            result = number1 * number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult division()
        {
            if (number2 == 0)
            {
                errorMessage = "Undefined, please reenter for 2nd number";
                return RedirectToAction(nameof(Index));
            }
            errorMessage = "";
            result = number1 / number2;
            return RedirectToAction(nameof(Index));
        }
    }
}

