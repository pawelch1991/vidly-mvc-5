
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "Number in stock")]
        [Required]
        public byte NumberInStock { get; set; }
    }
}