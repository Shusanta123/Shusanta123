using Microsoft.EntityFrameworkCore;
using ServiceRepositoryPattern.DLL.DbContext;

namespace ServiceRepositoryApi.StartupExtension;

public static class DataBaseExtensionHelper
{
    public static IServiceCollection AddDatabaseExtensionHelper(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
    
}