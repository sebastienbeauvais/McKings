using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business.Interfaces
{
    public interface Iterator
    {
        bool HasNext();
        IMenuItem Next();
    }
}
