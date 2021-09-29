using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my default action...";
        //}


        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //string res = HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return res;

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }
    }
}
