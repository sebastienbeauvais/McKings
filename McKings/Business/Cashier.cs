using McKings.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class Cashier
    {
        private readonly MenuHelper _menuHelper;
        public Cashier(MenuHelper menuHelper) 
        {
            _menuHelper = menuHelper;
        }
        public void PrintMenu()
        {
            //Prints all menu items
            _menuHelper.PrintMenuItems();
            Console.WriteLine("TODO");
        }
        public void PrintVegetarianMenu()
        {
            //Prints all vegetarian menu items
            Console.WriteLine("TODO");
        }
        public bool IsItemVegetarian(string name)
        {
            return true;
        }
    }
}
