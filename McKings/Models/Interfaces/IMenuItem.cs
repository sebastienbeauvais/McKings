using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Models.Interfaces
{
    public interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        bool IsVegitarian { get; set; }
    }
}
