using McKings.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business.Interfaces
{
    public interface IActionsStrategy
    {
        bool IsApplicable(string input);
        void PerformAction(Iterator menuIterator);
        string GetMenuType();
    }
}
