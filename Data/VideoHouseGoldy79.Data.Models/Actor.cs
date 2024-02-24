namespace VideoHouseGoldy79.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using VideoHouseGoldy79.Data.Common.Models;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Actor;

    public class Actor : BaseDeletableModel<int>
    {
        public Actor()
        {
            this.MovieActors = new HashSet<MovieActor>();
        }

        [Required]
        [MaxLength(ActorFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ActorLastNameMaxLength)]
        public string LastName { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
