using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizApp.UI.Models;

namespace QuizApp.UI.Controllers
{
    public class CoursesController : Controller
    {
        //
        // GET: /Courses/
        public ActionResult Index()
        {
            var courseInfoModel = new CourseInfoModel();
            courseInfoModel.CourseInfos.Add(new CourseInfo(){CourseId = 1, Name="Course1",Description = "CourseDescription",CourseTags = new List<string>(){"PHP","RUBY"}});
            courseInfoModel.CourseInfos.Add(new CourseInfo() {CourseId = 2,Name = "Course2", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 3, Name = "Course3", Description = "CourseDescription", CourseTags = new List<string>() { "JAVASCRIPT", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 4, Name = "Course4", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "JAVASCRIPT" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 5, Name = "Course5", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "JAVASCRIPT", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 6, Name = "Course6", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 7, Name = "Course7", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 8, Name = "Course8", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "RUBY" } });
            courseInfoModel.CourseInfos.Add(new CourseInfo() { CourseId = 9, Name = "Course9", Description = "CourseDescription", CourseTags = new List<string>() { "PHP", "RUBY" } });
            return View(courseInfoModel);
        }
        
        public ActionResult DisplayCourse(int courseId)
        {
            return View();
        }

    }
}
