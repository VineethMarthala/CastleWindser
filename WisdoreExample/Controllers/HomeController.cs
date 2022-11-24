using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WisdoreExample.Models;

namespace WisdoreExample.Controllers
{
    public class HomeController : Controller
    {

        private ToDoListService toDoListService;

        public HomeController(ToDoListService service)
        {
            this.toDoListService = service;
        }

        public ActionResult Index()
        {
            var model = toDoListService.GetToDoList();

            return View(model);
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