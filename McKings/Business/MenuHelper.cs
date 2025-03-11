using McKings.Data.Interfaces;
using McKings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class MenuHelper : IMenuHelper
    {
        private readonly List<IDatabase> _menuDatabase;
        public MenuHelper(List<IDatabase> menuDatabase)
        {
            _menuDatabase = menuDatabase;
        }

        public void PrintMenuItems()
        {
            foreach (var item in _menuDatabase) 
            {
                Console.WriteLine($"{item.menuItems}");

            }
        }
    }
}
