using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sekoya.BLL.Repository;
using Sekoya.DAL;

namespace Sekoya.WEB.Controllers
{
    public class HomeController : Controller
    {
        IssueBusiness businessIssue;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Issue model)
        {
            businessIssue = new IssueBusiness();
           
            Issue issue = new Issue();
            Log log = new Log();

            if (ModelState.IsValid)
            {
                issue.Title = "Apsiyon"; //model.Title
                issue.Contents = "Case Study"; // model.Contents
                businessIssue.InsertIssue(issue);
                return Json(new { Success = true });
            }
            return PartialView("Index", model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
