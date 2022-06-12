using Microsoft.Extensions.DependencyInjection;
using SistemaNotas.Interfaces;
using SistemaNotas.Repositories;
using SistemaNotas.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.DependencyInjection
{
    public class DependencyInjectionConfig
    {
        public static void Register(IServiceCollection service)
        {
            service.AddTransient<ISefazService, SefazService>();
            service.AddTransient<ISefazRepository, SefazRepository>();
        }

    }
}
