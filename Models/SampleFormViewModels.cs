using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace FIT5032_week05.Models
{
    public class SampleFormViewModels
    {
    }
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}