using Microsoft.AspNetCore.Mvc;
using PartialViewExample.Models;

namespace PartialViewExample.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        //ViewData["ListTitle"] = "Cities";
        //ViewData["ListItems"] = new List<string>()
        //{
        //    "Paris",
        //    "Rome",
        //    "Belgrade",
        //    "New York"
        //};
        return View();
    }

    [Route("about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("programming-languages")]
    public IActionResult ProgrammingLanguages()
    {
        ListModel listModel = new()
        {
            ListTitles = "",
            ListItems = new List<string>()
            {
                "C#",
                "C++",
                "Java",
                "Dart",
                "Pascal"
            }
        };
        //return new PartialViewResult(){ViewName = "_ListPartialView", Model = listModel}; 
        return  PartialView("_ListPartialView", listModel); 
    }
}
