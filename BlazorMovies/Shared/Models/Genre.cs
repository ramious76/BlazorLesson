using BlazorMovies.Shared.Models.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public List<MoviesGenres> MovieGenres { get; set; } = new List<MoviesGenres>();
    }
}
