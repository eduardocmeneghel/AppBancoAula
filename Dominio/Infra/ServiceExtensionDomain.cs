using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class ServiceExtensionDomain
    {
        public static void ConfigurarDominio(this IServiceCollection services,
                                                 IConfiguration configuration)
        {
            services.ConfigurarRepositorio(configuration);
        }
    }
}
