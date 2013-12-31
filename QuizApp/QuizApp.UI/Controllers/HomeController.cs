using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using QuizApp.UI.Models;
using QuizApp.UI.ViewModel;

namespace QuizApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IList<string> _reasonsList = new List<string>() {"Reason1", "Reason2"};

        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var activities = new RecentActivitiesModel();
            activities.Activities.Add( new Activity(){ActivityType = ActivityType.TestTake, CreatedOn = DateTime.Now,Message = "Temp1", State = ActivityState.New});
            activities.Activities.Add(new Activity() { ActivityType = ActivityType.TestTake, CreatedOn = DateTime.Now, Message = "Temp2", State = ActivityState.New });
            activities.Activities.Add(new Activity() { ActivityType = ActivityType.TestTake, CreatedOn = DateTime.Now, Message = "Temp3", State = ActivityState.New });
            ViewBag.ActivityModel = activities;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.DropDownList = new SelectList(_reasonsList);
            return View();
        }
        [HttpPost]
        public ActionResult Contact(FeedbackModel feedbackModel)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            ViewBag.Message = "Your contact page.";
            ViewBag.DropDownList = new SelectList(_reasonsList);
            
            if(Request.IsAjaxRequest())
                return Json(new {Status = true});
            
            return View();
        }
    }
}
