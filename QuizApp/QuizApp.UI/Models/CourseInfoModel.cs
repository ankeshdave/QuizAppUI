using System.Collections.Generic;

namespace QuizApp.UI.Models
{
    public class CourseInfoModel
    {
        private List<CourseInfo> _courseInfos = new List<CourseInfo>();

        public List<CourseInfo> CourseInfos
        {
            get { return _courseInfos; }
            set { _courseInfos = value; }
        }
    }

    public class CourseInfo
    {
        public int CourseId { get; set; }

        private List<string> _courseTags = new List<string>();
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public List<string> CourseTags
        {
            get { return _courseTags; }
            set { _courseTags = value; }
        }
    }
}