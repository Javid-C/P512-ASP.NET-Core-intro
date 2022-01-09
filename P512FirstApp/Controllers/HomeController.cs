using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P512FirstApp.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "index";
            return view;

        }

        public ActionResult About()
        {
            //return new ViewResult { ViewName = "About" };
            ViewBag.Name = "Rijat";
            ViewData["Surname"] = "Alizade";
            TempData["Age"] = 17;
            return RedirectToAction(nameof(Index));
            return View();
        }

        public ActionResult FAQ(string firstname,string surname)
        {
            string fullname = $"{firstname} {surname}";
            return Content(fullname);
            return View();
        }

        public ActionResult Contact(int id)
        {
            return Content(id.ToString());
            //return View();
        }
    }
}
