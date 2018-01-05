using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace DestinationTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";
            ViewData["Page"] = "Homepage";

            return View();
        }

        public ActionResult CaseA(string testparam)
        {
            var useragent = System.Web.HttpContext.Current.Request.UserAgent;
            if (useragent.ToLower().Contains("bot"))
            {
                Response.StatusCode = 403;
                Response.StatusDescription = "Bots have been blocked";
                return Content("403 Forbidden: Bots have been blocked from this page for security reasons.");
            }
            else
            {
                ViewData["Page"] = "Case A";
            }
            ViewData["testParam"] = testparam;
            return View();
        }

        public ActionResult CaseB(string testparam)
        {
            var cookies = System.Web.HttpContext.Current.Request.Cookies.Get(999);
            ViewData["Page"] = "Case B";
            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseC(string testparam)
        {
            var cookies = System.Web.HttpContext.Current.Request.Cookies;
            if (cookies.Count > 0)
            {
                ViewData["Page"] = "Case C";
            }
            else
            {
                // Implementation could set cookie here and redirect; leaving out for simplicity. 

                return RedirectToRoute(new { controller = "Home", action = "CaseC" });
            }
            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseD(string testparam)
        {
            if (Helpers.Utils.fBrowserIsMobile())
            {
                ViewData["Page"] = "Mobile Detected, redirecting...";
                return Redirect("m.destinationtraining.azurewebsites.net");
            }
            else
            {
                ViewData["Page"] = "Case D";
            }

            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseE(string testparam)
        {
            var useragent = System.Web.HttpContext.Current.Request.UserAgent;
            if (useragent.ToLower().Contains("bot"))
            {
                Response.StatusCode = 403;
                Response.StatusDescription = "Bots have been blocked";
                return Content("403 Forbidden: Bots have been blocked from this page for security reasons.");
            }
            else
            {
                ViewData["Page"] = "Case E";
            }
            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseF(string testparam)
        {
            var useragent = System.Web.HttpContext.Current.Request.UserAgent;
            if (useragent.ToLower().Contains("bot"))
            {
                Response.StatusCode = 403;
                Response.StatusDescription = "Bots have been blocked";
                return Content("403 Forbidden: Bots have been blocked from this page for security reasons.");
            }
            else
            {
                ViewData["Page"] = "Case F";
            }
            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseG(string testparam)
        {
            var useragent = System.Web.HttpContext.Current.Request.UserAgent;
            if (useragent.ToLower().Contains("bot"))
            {
                Response.StatusCode = 403;
                Response.StatusDescription = "Bots have been blocked";
                return Content("403 Forbidden: Bots have been blocked from this page for security reasons.");
            }
            else
            {
                ViewData["Page"] = "Case G";
            }
            ViewData["testParam"] = testparam;
            return View();
        }
        public ActionResult CaseH(string testparam)
        {
            var useragent = System.Web.HttpContext.Current.Request.UserAgent;
            if (useragent.ToLower().Contains("bot"))
            {
                Response.StatusCode = 403;
                Response.StatusDescription = "Bots have been blocked";
                return Content("403 Forbidden: Bots have been blocked from this page for security reasons.");
            }
            else
            {
                ViewData["Page"] = "Case H";
            }
            ViewData["testParam"] = testparam;
            return View();
        }

        public ActionResult TestPage(string testparam)
        {           
            ViewData["Page"] = "TestPage";
            ViewData["testParam"] = testparam;
            return View();
        }
    }
}
