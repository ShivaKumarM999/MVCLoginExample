using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLoginExample.Models
{
    public class Calculator
    {
        [Required]
        [Display(Name ="Enter Number1")]
        public int Num1 { get; set; }


        [Required]
        [Display(Name = "Enter Number2")]
        public int Num2 { get; set; }


        public int Result { get; set; }
    }
}