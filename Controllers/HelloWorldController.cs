using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string text)
        {
            return HtmlEncoder.Default.Encode($"This is the Welcome action method... You entered {text}");
        }
    }
}