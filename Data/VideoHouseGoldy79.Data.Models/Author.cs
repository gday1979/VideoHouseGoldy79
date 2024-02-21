namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using VideoHouseGoldy79.Data.Common.Models;

    public class Author: BaseDeletableModel<int>
    {
        public Author()
        {
            this.Reviews = new HashSet<ReviewAuthor>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public virtual ICollection<ReviewAuthor>Reviews { get; set; }
    }
}
