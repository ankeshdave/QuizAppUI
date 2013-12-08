using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizApp.UI.Areas.User.Controllers
{
    [Authorize(Users = "admin")]
    public class HomeController : Controller
    {
        //
        // GET: /User/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
