namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using VideoHouseGoldy79.Data.Common.Models;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Author;

    public class Author : BaseDeletableModel<int>
    {
        public Author()
        {
            this.Reviews = new HashSet<ReviewAuthor>();
        }

        [Required]
        [MaxLength(AuthorFirstNameMaxLenght)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AuthorLastNameMaxLenght)]
        public string LastName { get; set; }

        public string Email { get; set; }

        public virtual ICollection<ReviewAuthor> Reviews { get; set; }
    }
}
