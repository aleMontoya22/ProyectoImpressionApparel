using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistema.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Sistema.IoC
{
    public static class Dependencia{

        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<DbventaContext>(options =>{
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}