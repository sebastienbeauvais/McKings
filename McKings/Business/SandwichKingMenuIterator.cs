using McKings.Data.Interfaces;
using McKings.Data;
using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McKings.Business.Interfaces;

namespace McKings.Business
{
    public class SandwichKingMenuIterator : Iterator
    {
        private List<IMenuItem> _sandwichKingMenuDb;
        int position = 0;
        public SandwichKingMenuIterator(IEnumerable<IDatabase> sandwichKingMenuDb)
        {
            _sandwichKingMenuDb = sandwichKingMenuDb.OfType<SandwichKingsMenuItemsDb>().SelectMany(db => db.GetMenuItems()).ToList();
        }
        public IMenuItem Next()
        {
            IMenuItem menuItem = (IMenuItem)_sandwichKingMenuDb[position];
            position++;
            return menuItem;
        }
        public bool HasNext()
        {
            if (position >= _sandwichKingMenuDb.Count() || _sandwichKingMenuDb[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
