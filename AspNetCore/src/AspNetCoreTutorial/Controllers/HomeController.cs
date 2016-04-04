using Microsoft.AspNet.Mvc;
using AspNetCoreTutorial.Model;
using Microsoft.Framework.OptionsModel;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTutorial.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext dataContext = new ProductContext();

        public HomeController(IOptions<MyOptions> options )
        {
           var foo = options.Options.cor;
        }
        public IActionResult Foo()
        {
            ViewData["Message"] = "I'm a Home Controller";
            return View();
        }
        [HttpGet("/ical")]
        [Produces("text/calendar")]
        public IActionResult PersonDetail() => View();

        [HttpPost]
        public IActionResult PersonDetail(Person person)
        {
            return  View(dataContext.Product);
        }
      
    }
}
