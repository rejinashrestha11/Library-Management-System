using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class Publication
    {
        [Key]
        public int Publication_id { get; set; }

        [Required(ErrorMessage = "Publication name is required")]
        [Display(Name = "Publication Name")]
        public string PublicationName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        public string Contact_No { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
