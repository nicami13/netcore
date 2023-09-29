

namespace API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)=>
        services.AddCors(options=>
        {
        options.AddPolicy("Corspolicy",builder=>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
    }
}