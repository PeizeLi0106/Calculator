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
            return View(); 
        }

       
        public IActionResult addition(decimal num1, decimal num2)
        {
            number1 = num1;
            number2 = num2;
            result = number1 + number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
  
        }
        public IActionResult subtraction(decimal num1, decimal num2)
        {
            number1 = num1;
            number2 = num2;
            result = number1 - number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult multiplication(decimal num1, decimal num2)
        {
            number1 = num1;
            number2 = num2;
            result = number1 * number2;
            errorMessage = "";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult division(decimal num1, decimal num2)
        {
            number1 = num1;
            number2 = num2;
            if (number2 == 0)
            {
                result = 0;
                errorMessage = "Undefined, please reenter for the 2nd number";
                return RedirectToAction(nameof(Index));
            }
            errorMessage = "";
            result = number1 / number2;
            return RedirectToAction(nameof(Index));
        }
    }
}

