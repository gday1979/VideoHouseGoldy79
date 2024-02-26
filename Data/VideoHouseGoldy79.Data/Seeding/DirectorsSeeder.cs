namespace VideoHouseGoldy79.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static VideoHouseGoldy79.Data.Common.DataValidation;

    public class DirectorsSeeder : ISeeder
    {
        public async Task SeedAsync(VideoHouseGoldy79DbContext dbContext, IServiceProvider serviceProvider)
        {
           if ( dbContext.Directors.Any())
            {
                return;
            }

           var directors = new List<(string FirstName, string LastName)>
            {
               ("Quentin", "Tarantino"),
               ("Christopher", "Nolan"),
               ("Martin", "Scorsese"),
               ("Steven", "Spielberg"),
               ("David", "Fincher"),
               ("James", "Cameron"),
               ("Ridley", "Scott"),
               ("Tim", "Burton"),
               ("Peter", "Jackson"),
               ("George", "Lucas"),
               ("Francis Ford", "Coppola"),
               ("Stanley", "Kubrick"),
               ("Alfred", "Hitchcock"),
               ("Sergio", "Leone"),
               ("Akira", "Kurosawa"),
               ("Ingmar", "Bergman"),
               ("Federico", "Fellini"),
               ("Jean-Luc", "Godard"),
               ("Fritz", "Lang"),
               ("Billy", "Wilder"),
               ("John", "Ford"),
               ("Orson", "Welles"),
               ("David", "Lynch"),
               ("Woody", "Allen"),
               ("Roman", "Polanski"),
           };

            foreach (var director in directors)
            {
               await dbContext.Directors.AddAsync(new Director
                {
                    FirstName = director.FirstName,
                    LastName = director.LastName,
                });
            }
        }
    }
}
