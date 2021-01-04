
using GestaoContabil.Data.Context;
using GestaoContabil.Data.Repository;
using GestaoContabil.Interfaces;
using GestaoContabil.Notifications;
using GestaoContabil.Services;
using GestaoContabil.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDepedencies(this IServiceCollection services)
        {

            services.AddScoped<GestaoContabilContext>();
            services.AddScoped<SeedingService>();
            services.AddScoped<INotifier, Notifier>();

            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<IReceitaService, ReceitaService>();

            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IDespesaService, DespesaService>();

            return services;
        }
    }
}
