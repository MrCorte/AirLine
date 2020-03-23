using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLine.ApplicationCore;
using AirLine.ApplicationCore.Interfaces;
using AirLine.Controllers;
using AirLine.Infrastructure;
using AirLine.Infrastructure.Interfaces;

namespace AirLine
{
    public static class ConfingureConteainerExtantions
    {
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            // infrastructure
            serviceCollection.AddTransient<IPersonaRepository, PersonaRepository>();
            
            
            // applicationcore
            serviceCollection.AddTransient<IPersonaService, PersonaService>();
        }
    }
}