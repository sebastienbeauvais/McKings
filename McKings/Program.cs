using McKings;
using Microsoft.Extensions.DependencyInjection;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            var posManager = serviceProvider;
        }
        private static ServiceProvider ConfigureServices()
        {
            //Set DI
            var services = new ServiceCollection();

            //Register
            services.AddScoped<McKings.McKings, McKings.McKings>();

            return services.BuildServiceProvider();
        }
    }
}