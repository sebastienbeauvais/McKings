using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business.Interfaces
{
    public interface IIterator
    {
        bool MoveNext();
        bool Next();
    }
}
