using EslamiSepehr.EventBus.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace EslamiSepehr.EventBus.Extenstions
{
    public static class EventBusExtenions
    {
        public static void AddEsEventBus<EventBus>(this IServiceCollection services)
            where EventBus : class, IEventBus
        {
            services.AddSingleton<IEventBus, EventBus>();
            services.AddSingleton<IEventBusSubscriptionsManager, InMemoryEventBusSubscriptionsManager>();
        }
    }
}
