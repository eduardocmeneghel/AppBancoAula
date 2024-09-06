using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public static class ServicesExtesionRepository
    {
        public static void ConfigurarRepositorio(this IServiceCollection services,
                                                 IConfiguration configuration)
        {
            var enderecoBanco = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(enderecoBanco));

            GeradorDeServicos.serviceProvider = services.BuildServiceProvider();
        }
    }
}
