using System;
using System.ComponentModel.DataAnnotations; //namespace that provides formatting attributes in addition to the built-in set of validation attributes
using System.ComponentModel.DataAnnotations.Schema;

namespace iMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        // Adding validation attributes to specify behavior we want to
        // enforce on the model properties they're applied to.
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        // Data annotation to enable EFC to correctly map to currency in DB.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
