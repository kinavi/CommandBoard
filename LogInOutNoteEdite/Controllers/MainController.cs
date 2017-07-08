using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogInOutNoteEdite.Models;
using LogInOutNoteEdite.Util;

namespace LogInOutNoteEdite.Controllers
{
    public class MainController : Controller
    {
        DivProjects divProjects = new DivProjects();

        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(UsersBase uBase)
        {

            if (uBase.CheckForm())
            {
                ViewBag.List = divProjects.listProjects;
                return View("Projects");
            }
            return View("Index");
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }
        //[HttpGet] // Мы добавили атрибут HttpGet для нашего существующего метода действия RsvpForm. 
        //public ViewResult RsvpForm() // Это говорит MVC, что данный метод должен использоваться только для GET запросов. 
        //{
        //    return View("Index");
        //}


    }
}