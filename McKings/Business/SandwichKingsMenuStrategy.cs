using McKings.Business.Interfaces;
using McKings.Data.Interfaces;
using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class SandwichKingsMenuStrategy : IActionsStrategy
    {
        private static string _menuType = "SandwichKing";
        public bool IsApplicable(string input)
        {
            return input == "2";
        }
        public string GetMenuType()
        {
            var menuType = _menuType;
            return menuType;
        }
        public void PerformAction(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                IMenuItem menuItem = iterator.Next();
                string itemName = GetItemName(menuItem);
                double itemPrice = GetItemPrice(menuItem);
                string itemDescription = GetItemDescription(menuItem);
                Console.WriteLine($"{itemName} , {itemPrice} -- {itemDescription}");
            }
        }
        private string GetItemName(IMenuItem menuItem)
        {
            return menuItem.Name;
        }
        private double GetItemPrice(IMenuItem menuItem)
        {
            return menuItem.Price;
        }
        private string GetItemDescription(IMenuItem menuItem)
        {
            return menuItem.Description;
        }
    }
}
