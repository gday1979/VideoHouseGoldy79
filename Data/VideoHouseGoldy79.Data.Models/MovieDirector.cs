namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MovieDirector
    {
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
