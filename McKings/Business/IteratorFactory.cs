using McKings.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class IteratorFactory : IIteratorFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public IteratorFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public Iterator CreateIterator(string menuType)
        {
            return menuType switch
            {
                "McDolands" => _serviceProvider.GetRequiredService<McDolandsMenuIterator>(),
                "SandwichKing" => _serviceProvider.GetRequiredService<SandwichKingMenuIterator>(),
                _ => throw new ArgumentException("Invalid menu type")
            };
        }
    }
}
