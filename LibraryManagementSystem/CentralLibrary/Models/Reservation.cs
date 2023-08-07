
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_id { get; set; }

        [Required(ErrorMessage = "Book id is required")]
        [Display(Name = "Book Id")]
        public int Book_id { get; set; }

        [Required(ErrorMessage = "Card ID is required")]
        [Display(Name = "Card ID")]
        public int Card_id { get; set; }

        [Required(ErrorMessage = "Date Reserved is required")]
        [Display(Name = "Reserved Date")]
        public string Reservation_date { get; set; }

    }
}
