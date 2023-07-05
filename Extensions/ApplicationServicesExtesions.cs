using API.Data;
using API.Interfaes;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServicesExtesions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(otp =>
                    {
                         otp.UseSqlite(config.GetConnectionString(config["DefaultConnection"]));
                    });

                    return services;
        }
    }
}