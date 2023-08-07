using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class AdminLogin
    {
        [Key]
        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "Username")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public String Password { get; set; }    
    }
}
