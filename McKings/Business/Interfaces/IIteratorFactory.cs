using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business.Interfaces
{
    public interface IIteratorFactory
    {
        Iterator CreateIterator(string menuType);
    }
}
