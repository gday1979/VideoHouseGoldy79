namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using VideoHouseGoldy79.Data.Common.Models;
    using VideoHouseGoldy79.Data.Models.Enumerations;

    public class Movie : BaseDeletableModel<int>
    {
        public Movie()
        {
            

        }
        [Required]
        public string Name { get; set; }

        public DateTime DateOfRelease { get; set; }

        public decimal Rating { get; set; }

        public string Director { get; set; }



        [Required]
        public string Description { get; set; }

        [Required]
        public MovieCategory MovieCategory { get; set; }
    }
}
