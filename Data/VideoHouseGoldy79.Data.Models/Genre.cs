namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using VideoHouseGoldy79.Data.Common.Models;

    public class Genre : BaseDeletableModel<int>
    {
        public Genre()
        {
            this.MoviesGenres = new HashSet<MovieGenre>();
        }

        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MoviesGenres { get; set; }
    }
}
