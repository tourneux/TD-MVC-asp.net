using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nwd.BackOffice.Impl;

namespace Nwd.mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AlbumRepository alre = new AlbumRepository();
            return View( alre.GetAllAlbums() );
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