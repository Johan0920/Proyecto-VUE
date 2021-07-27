using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VUE.Dominio.Repositorios;
using VUE.Infraestructura.Persistencia.InsightDatabase.Repositorios;

namespace VUE.Infraestructura
{
   public static  class InyeccionDependendia
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IContribuyenteRepositorio, ContribuyenteRepositorio>();

            return services;
        }
    }
}
