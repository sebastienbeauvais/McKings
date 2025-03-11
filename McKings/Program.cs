using McKings;
using McKings.Business;
using McKings.Business.Interfaces;
using McKings.Data;
using McKings.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            var posManager = serviceProvider.GetRequiredService<McKings.McKings>();

            posManager.EnterRestaurant();
        }
        private static ServiceProvider ConfigureServices()
        {
            //Set DI
            var services = new ServiceCollection();

            //Register
            services.AddScoped<McKings.McKings, McKings.McKings>();
            services.AddScoped<IPosManager, PosManager>();

            services.AddScoped<McDolandsMenuIterator>();
            services.AddScoped<SandwichKingMenuIterator>();
            services.AddScoped<IIteratorFactory, IteratorFactory>();

            services.AddScoped<IActionsStrategy, McDolandsMenuStrategy>();
            services.AddScoped<IActionsStrategy, SandwichKingsMenuStrategy>();

            services.AddScoped<IDatabase, McDolandsMenuItemsDb>();
            services.AddScoped<IDatabase, SandwichKingsMenuItemsDb>();


            return services.BuildServiceProvider();
        }
    }
}