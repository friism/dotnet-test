using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_on_lyra.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("")]
        public IActionResult Test()
        {
            Console.WriteLine($"I got something at {DateTime.Now:HH:mm:ss}");

            using (var reader = new StreamReader(Request.Body))
            {
                var body = reader.ReadToEnd();

                Console.WriteLine(body);
            }
            return new EmptyResult();
        }
    }
}
