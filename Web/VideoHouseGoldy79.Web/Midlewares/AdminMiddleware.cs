namespace VideoHouseGoldy79.Web.Midlewares
{
    using System;
    using System.Threading.Tasks;

    using Azure.Core;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;

    public class AdminMiddleware
    {
        private readonly RequestDelegate next;

        public AdminMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, UserManager<VideoHouseGoldy79User> userManager)
        {
            await SeedUserInRoles(userManager);
            await next(context);
        }

        private async Task SeedUserInRoles(UserManager<VideoHouseGoldy79User> userManager)
        {
            await Task.Run(() =>
            {
                throw new NotImplementedException();
            });
        }
    }
}
