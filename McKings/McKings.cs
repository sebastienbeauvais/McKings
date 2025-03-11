using McKings.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings
{
    public class McKings
    {
        private readonly IPosManager _posManager;
        private readonly IIteratorFactory _iteratorFactory;
        public McKings(IPosManager posManager, IIteratorFactory iteratorFactory) 
        {
            _posManager = posManager;
            _iteratorFactory = iteratorFactory;
        }
        public void EnterRestaurant()
        {
            Console.WriteLine("Welcome to McKings! The new restaurant from a business merger. It combines the best items from all the restuarants we merge!!!\n");

            string userInput = "default";

            while (userInput != "99")
            {
                _posManager.ShowMenu();
                userInput = Console.ReadLine();
                _posManager.HandleUserInput(userInput);
            }

            Console.WriteLine("\nThank you for coming to McKings. Please come again and let us know which restaurant we should merge next!");
        }
    }
}
