using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class GeradorDeServicos
    {
        public static ServiceProvider serviceProvider;

        public static DataContext CarregarContexto()
        {
            return serviceProvider.GetService<DataContext>();
        }

    }
}
