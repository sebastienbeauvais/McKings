using McKings.Business.Interfaces;
using McKings.Data;
using McKings.Data.Interfaces;
using McKings.Models;
using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business
{
    public class McDolandsMenuIterator : Iterator
    {
        private List<IMenuItem> _mcDolandsMenuDb;
        int position = 0;
        public McDolandsMenuIterator(IEnumerable<IDatabase> mcDolandsMenuDb)
        {
            _mcDolandsMenuDb = mcDolandsMenuDb.OfType<McDolandsMenuItemsDb>().SelectMany(db => db.GetMenuItems()).ToList();
        }
        public IMenuItem Next()
        {
            IMenuItem menuItem = (IMenuItem)_mcDolandsMenuDb[position];
            position++;
            return menuItem;
        }
        public bool HasNext()
        {
            if(position >= _mcDolandsMenuDb.Count() || _mcDolandsMenuDb[position] == null)
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
