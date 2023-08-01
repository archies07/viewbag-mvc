using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viewbag.Models;

namespace viewbag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Message from viewbag !!";
            ViewBag.Currentdate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", "banana", "Orange" };
            ViewBag.FruitArray = fruits;

            ViewBag.Sportslist = new List<string>()
            {
                "cricket",
                "football",
                "hockey",
                "baseball"
            };

            Employee Archies= new Employee();
            Archies.EmpId= 1;
            Archies.EmpName = "Archies Patil";
            Archies.EmpDesignation = "Software Developer";

            ViewBag.Employee = Archies;

            ViewBag.CommonMessage = "This message is accessible by both Viewbag and viewdata";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}