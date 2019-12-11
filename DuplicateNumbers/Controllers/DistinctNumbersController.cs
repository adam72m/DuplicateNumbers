using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Oodit.Controllers
{
    public class DistinctNumbersController : Controller
    {
        // GET
        public IActionResult Index(Dictionary<int, int> numbers)
        {
            
            return View(numbers);
        }

        public IActionResult ReturnDuplicateNumbers(int[] numbers)
        {
            var test = numbers.GroupBy(x => x).Where(x => x.Count() > 1).ToDictionary(x => x.Key, x => x.Count());
            var i = numbers;
            return View("Index", test);
        }
    }
}