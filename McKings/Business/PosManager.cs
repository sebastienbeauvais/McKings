using McKings.Business.Interfaces;
using McKings.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class PosManager : IPosManager
    {
        private IEnumerable<IActionsStrategy> _actionsStrategies;
        private readonly IIteratorFactory _iteratorFactory;
        public PosManager(IEnumerable<IActionsStrategy> actionsStrategies, IIteratorFactory iteratorFactory)
        {
            _actionsStrategies = actionsStrategies;
            _iteratorFactory = iteratorFactory;
        }
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Show McDolands menu");
            Console.WriteLine("2. Show Sandwich King menu");
            Console.WriteLine("3. Show vegetarian menu");
            Console.WriteLine("4. Check if item is vegetarian");
            Console.WriteLine("99. Leave store");

        }
        public void HandleUserInput(string userInput)
        {
            //Apply A strategy
            var strategy = getStrategyToApply(userInput);
            var iterator = _iteratorFactory.CreateIterator(strategy.GetMenuType());
            strategy.PerformAction(iterator);
            
        }
        private IActionsStrategy getStrategyToApply(string userInput)
        {
            return _actionsStrategies.First(x => x.IsApplicable(userInput));
        }
    }
}
