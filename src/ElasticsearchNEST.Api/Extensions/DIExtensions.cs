using ElasticsearchNEST.Data.Repositories;
using ElasticsearchNEST.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ElasticsearchNEST.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
            => services.AddTransient<IRepository, Repository>();
    }
}