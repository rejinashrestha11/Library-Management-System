using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class LibraryCard
    {
        [Key]
        public int Card_id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Faculty is required")]
        [Display(Name = "Faculty")]
        public string Faculty { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        public string Contact_No { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Issued date is required")]
        [Display(Name = "Issued date")]
        public string Issued_date { get; set; }

        [Required(ErrorMessage = "Expire date is required")]
        [Display(Name = "Expire date")]
        public string Expire_date { get; set; }
    }
}
