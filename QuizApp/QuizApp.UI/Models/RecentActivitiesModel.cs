using System;
using System.Collections.Generic;

namespace QuizApp.UI.Models
{
    public class RecentActivitiesModel
    {
        private List<Activity> _activities = new List<Activity>();

        public List<Activity> Activities
        {
            get { return _activities; }
            set { _activities = value; }
        }
    }

    public class Activity
    {
        public ActivityState State { get; set; }

        public ActivityType ActivityType { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Message { get; set; }

    }

    public enum ActivityState
    {
        New,
        Read,
    }

    public enum ActivityType
    {
        TestTake
    }
}