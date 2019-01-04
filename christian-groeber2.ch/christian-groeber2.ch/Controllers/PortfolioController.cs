using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace christian_groeber2.ch.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Programming()
        {
            return View();
        }

        public ActionResult Photos()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        //[Route("Portfolio/Projects")]
        //public ActionResult PreciousHands()
        //{
        //    return View();
        //}

        //[Route("Portfolio/Projects")]
        //public ActionResult ParisBlog()
        //{
        //    return View();
        //}

        //[Route("Portfolio/Projects")]
        //public ActionResult howToPhotography()
        //{
        //    return View();
        //}

        //[Route("Portfolio/Projects")]
        //public ActionResult CokePad()
        //{
        //    return View();
        //}
    }
}