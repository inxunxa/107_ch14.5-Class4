using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using taskManager.Models;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet]
        public IActionResult Test()
        {
            var list = new List<string>();
            return Json(list);
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return null;
        }

        [HttpPost]
        public IActionResult SaveTask([FromBody] Task theTask)
        {

            // sanitize the user input before storing in DB 
            // sanitiza user input MVC C#

            System.Console.WriteLine("Saving an object: " + theTask.Title);
            theTask.Id = 1;

            return Json(theTask);
        }

    }
}