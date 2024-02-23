namespace VideoHouseGoldy79.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.ExceptionServices;
    using System.Text;
    using System.Threading.Tasks;

    using static VideoHouseGoldy79.Data.Common.DataValidation.Actor;

    public class Actor
    {
       [Required]
       [MaxLength(ActorFirstNameMaxLength)]
       public string FirstName { get; set; }

       [Required]
       [MaxLength(ActorLastNameMaxLength)]
       public string LastName { get; set; }

       public virtual ICollection<MovieActor> Actors { get; set; }
    }
}
