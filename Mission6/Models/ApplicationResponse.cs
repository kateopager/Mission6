using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieReviewID { get; set; }
        [Required(ErrorMessage ="Movie Title Required")] /*the variables from the form are set up below with the desired input type and get/set to send the information to the form variable*/
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie Year Required")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "Movie Director Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Movie Rating Required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "Movie Category Required")]
        public int CategoryID { get; set; } //this will build a fk relationship below
        public Category Category { get; set; }
    }
}
