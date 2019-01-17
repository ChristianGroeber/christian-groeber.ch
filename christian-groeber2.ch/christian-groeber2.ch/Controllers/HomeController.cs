﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace christian_groeber2.ch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("About-me")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Photography")]
        public ActionResult Photography()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Portfolio")]
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Other")]
        public ActionResult Other()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}