using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class Fine
    {
        [Key]
        public int Fine_id { get; set; }

        [Required(ErrorMessage = "Book id is required")]
        [Display(Name = "Book Id")]
        public int Book_id { get; set; }

        [Required(ErrorMessage = "Card ID is required")]
        [Display(Name = "Card ID")]
        public int Card_id { get; set; }

        [Required(ErrorMessage = "Date Taken is required")]
        [Display(Name = "Taken Date")]
        public string Taken_date { get; set; }

        [Required(ErrorMessage = "Date returned is required")]
        [Display(Name = "Return Date")]
        public string Return_date { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Display(Name = "Payment Amount")]
        public string Fine_amount { get; set; }
    }
}
