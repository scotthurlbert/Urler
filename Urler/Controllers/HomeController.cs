using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Urler.Controllers
{
    public class HomeController : Controller
    {
        public static string LastUrl { get; set; }

        public ActionResult Index()
        {
            ViewBag.LastUrl = LastUrl;

            return View();
        }

        public ActionResult SaveUrl( string url )
        {
            if( !string.IsNullOrEmpty( url ) )
            {
                LastUrl = url;
            }
            return RedirectToAction( "Index" );
        }

        public JsonResult GetUrl()
        {
            var result = new { Url = LastUrl };
            return Json( result, JsonRequestBehavior.AllowGet );
        }

        public ActionResult GotoUrl()
        {
            if( String.IsNullOrEmpty( LastUrl ) ) { return RedirectToAction( "Index" ); }
            return Redirect( LastUrl );
        }
    }
}
