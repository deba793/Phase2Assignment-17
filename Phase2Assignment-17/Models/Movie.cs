﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase2Assignment_17.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
