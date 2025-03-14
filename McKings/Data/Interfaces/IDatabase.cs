﻿using McKings.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Data.Interfaces
{
    public interface IDatabase
    {
        List<IMenuItem> menuItems { get;  }
        IEnumerable<IMenuItem> GetMenuItems();
    }
}
