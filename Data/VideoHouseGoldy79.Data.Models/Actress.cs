namespace VideoHouseGoldy79.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using VideoHouseGoldy79.Data.Common.Models;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Actress;

    public class Actress : BaseDeletableModel<int>
    {
        public Actress()
        {
            this.MovieActreses = new HashSet<MovieActress>();
        }

        [Required]
        [MaxLength(ActressFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ActressLastNameMaxLength)]
        public string LastName { get; set; }

        public virtual ICollection<MovieActress> MovieActreses { get; set; }
    }
}
