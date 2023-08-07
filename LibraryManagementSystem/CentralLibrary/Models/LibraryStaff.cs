using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CentralLibrary.Models
{
    public class LibraryStaff
    {
        [Key]
        public int Staff_id { get; set; }

        [Required(ErrorMessage = "Staff name is required")]
        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string address { get; set; }


        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        public string Contact_No { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department Name")]
        public string Department { get; set; }
    }
}
