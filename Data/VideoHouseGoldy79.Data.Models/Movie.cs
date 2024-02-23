namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using VideoHouseGoldy79.Data.Common.Models;
    using VideoHouseGoldy79.Data.Models.Enumerations;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Movie;

    public class Movie : BaseDeletableModel<int>
    {
        public Movie()
        {
            this.MovieActors = new HashSet<MovieActor>();
            this.MovieActresses = new HashSet<MovieActress>();
            this.Reviews = new HashSet<Review>();
            this.MovieGenres = new HashSet<MovieGenre>();
        }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfRelease { get; set; }

        public decimal Rating { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public MovieCategory MovieCategory { get; set; }

        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }

        public virtual ICollection<MovieActress> MovieActresses { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }

        public virtual ICollection<MovieReview> MovieReviews { get; set; }
    }
}
