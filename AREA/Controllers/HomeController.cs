using AREA.Models;
using Facebook;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AREA.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            string CurrentUserId = Environment.GetEnvironmentVariable("UserId");
            ViewBag.userId = CurrentUserId;
            return View();
        }

        [Authorize]
        public ActionResult GetFacebookAccess()
        {
            return Redirect("https://www.facebook.com/v2.11/dialog/oauth?client_id=1867059553604361&redirect_uri=https://localhost:44303/Home/GetAccessToken&response_type=token&scope=public_profile,publish_actions");
        }

        [Authorize]
        public ActionResult GetAccessToken()
        {
            var context = System.Web.HttpContext.Current;
            var access_token = context.Request["access_token"];

            System.Diagnostics.Debug.WriteLine("aaaaaaaaaaaaaaaaaaaaèèèèèèèèèèèèèèèèèèèèèèèèèè---------------------------------");
            System.Diagnostics.Debug.WriteLine(access_token);
            return Redirect("/");
        }
    }
}