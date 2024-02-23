namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Director;

    public class Director
    {
        public Director()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Required]
        [MaxLength(DirectorFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DirectorLastNameMaxLength)]
        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
