using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizApp.UI.Models
{
    public class FeedbackModel
    {
        public FeedbackModel()
        {
            Reasons = new List<string>(){"Reason1", "Reason2", "Reason3"};
        }
        [Required]
        [Display(Name = "User name")]
        public string Name { get; set; }

        public string EmailId { get; set; }

        [Required]
        [Display(Name = "Concern")]
        public string Reason { get; set; }

        [Required]
        [Display(Name = "Summary")]
        public string Summary { get; set; }

        public List<string> Reasons { get; set; }
    }
}