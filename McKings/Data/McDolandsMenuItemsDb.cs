using McKings.Data.Interfaces;
using McKings.Models;
using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Data
{
    public class McDolandsMenuItemsDb : IDatabase
    {
        public List<IMenuItem> menuItems { get; } = new List<IMenuItem>
        {
            new MenuItem{ Id = 1, Name = "McBurger", Description = "Beef Patty, Bun, Cheese.", Price = 3.99, IsVegitarian = false},
            new MenuItem{ Id = 2, Name = "McBurger Deluxe", Description = "Beef Patty, Bun, Cheese, Tomatoe, Lettuce, Grilled Onions.", Price = 4.99, IsVegitarian = false},
            new MenuItem{ Id = 3, Name = "Double McBurger", Description = "Double Beef Patty, Bun, Cheese.", Price = 4.99, IsVegitarian = false},
            new MenuItem{ Id = 4, Name = "McVeg Burger", Description = "Veggie Patty, Whole Wheat Bun, Swiss Cheese", Price = 4.49, IsVegitarian = true},
        };
        public IEnumerable<IMenuItem> GetMenuItems() => menuItems;
    }
}
