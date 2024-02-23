namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Actress;

    public class Actress
    {
        [Required]
        [MaxLength(ActressFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ActressLastNameMaxLength)]
        public string LastName { get; set; }

        public virtual ICollection<MovieActress> MovieActreses { get; set; }
    }
}
