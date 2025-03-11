using McKings.Data.Interfaces;
using McKings.Models.Interfaces;
using McKings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Data
{
    public class SandwichKingsMenuItemsDb : IDatabase
    {
        public List<IMenuItem> menuItems { get; } = new List<IMenuItem>
        {
            new MenuItem{ Id = 1, Name = "Turkey & Swiss", Description = "Whole lotta swiss, even more turkey", Price = 5.99, IsVegitarian = false},
            new MenuItem{ Id = 2, Name = "Chicken Pesto", Description = "The best sandwich known to man!", Price = 6.99, IsVegitarian = false},
            new MenuItem{ Id = 3, Name = "Grilled Cheese", Description = "You dont know what a grilled cheese is?", Price = 4.99, IsVegitarian = false},
            new MenuItem{ Id = 4, Name = "Veggie Delux", Description = "Bread with every veggie smashed between", Price = 5.49, IsVegitarian = true},
        };
        public IEnumerable<IMenuItem> GetMenuItems() => menuItems;
    }
}
