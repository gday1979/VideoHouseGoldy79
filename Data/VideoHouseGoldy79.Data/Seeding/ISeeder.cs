namespace VideoHouseGoldy79.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(VideoHouseGoldy79DbContext dbContext, IServiceProvider serviceProvider);
    }
}
