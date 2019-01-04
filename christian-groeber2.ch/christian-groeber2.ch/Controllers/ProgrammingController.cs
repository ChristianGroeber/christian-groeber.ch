using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace christian_groeber2.ch.Controllers
{
    public class ProgrammingController : Controller
    {
        // GET: Project
        [Route("Portfolio/Programming/PreciousHands")]
        public ActionResult PreciousHands()
        {
            return View();
        }

        [Route("Portfolio/Programming/ParisBlog")]
        public ActionResult ParisBlog()
        {
            return View();
        }

        [Route("Portfolio/Programming/howToPhotography")]
        public ActionResult howToPhotography()
        {
            return View();
        }

        [Route("Portfolio/Programming/CokePad")]
        public ActionResult CokePad()
        {
            return View();
        }
    }
}