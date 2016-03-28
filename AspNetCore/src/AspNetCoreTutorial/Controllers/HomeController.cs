using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AspNetCoreTutorial.Model;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.OptionsModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreTutorial.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(IOptions<MyOptions> options )
        {
           var foo = options.Options.cor;
        }
        public IActionResult Foo()
        {
            ViewData["Message"] = "I'm a Home Controller";
            return View();
        }
        [HttpGet]
        public IActionResult PersonDetail() => View();

        [HttpPost]
        public IActionResult PersonDetail(Person person)
        {
            return View(person);
        }
      
    }
}
