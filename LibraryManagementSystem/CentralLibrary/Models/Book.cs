using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Models
{
    public class Book
    {
        [Key]
        public int Book_id { get; set; }

        [Required(ErrorMessage= "Book name is required")]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "ISBN Number is required")]
        [Display(Name = "ISBN Number")]
        public int ISBN_NO { get; set; }

        [Required(ErrorMessage = "Publish year is required")]
        [Display(Name = "Publish Year")]
        public string publish_year { get; set; }

        [Required(ErrorMessage = "Author name is required")]
        [Display(Name = "Author Name")]
        public string author { get; set; }
    }
}
