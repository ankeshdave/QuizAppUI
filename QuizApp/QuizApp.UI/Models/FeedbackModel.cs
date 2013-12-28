using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizApp.UI.Models
{
    public class FeedbackModel
    {

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string EmailId { get; set; }

        [Required]
        [Display(Name = "Reason")]
        public string Reason { get; set; }

        [Required]
        [Display(Name = "Summary")]
        public string Summary { get; set; }
        
    
    }
   
}