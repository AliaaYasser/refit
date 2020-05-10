using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace refit1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
           
            return View(db.news.Where(x => x.isActive == true).ToList());
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

        public ActionResult Login()
        {



            return View();
        }
        public ActionResult allNews()
        {


            return View();
        }
        public ActionResult allAdminNews()
        {


            return View();
        }
        public ActionResult editePost()
        {


            return View();
        }

        public ActionResult addNews()
        {
            return View();
        }
    }
}