namespace VideoHouseGoldy79.Web.Midlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class AdminMiddlewareExtensions
    {
        public static IApplicationBuilder UseAdminMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdminMiddleware>();
        }
    }
}
