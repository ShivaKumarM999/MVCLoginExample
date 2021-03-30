using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLoginExample.Models
{
    public class EmpLogin
    {
        [Required]
        [Display(Name ="Enter User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Enter User name")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}