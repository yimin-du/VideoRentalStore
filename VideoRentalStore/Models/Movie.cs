using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalStore.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name="Genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name="Release Date")]
        public DateTime DateReleased { get; set; }

        [Display(Name="Number in stock")]
        public byte NumberInStock { get; set; }
    }
}