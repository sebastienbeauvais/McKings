using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKings.Business.Interfaces
{
    public interface IPosManager
    {
        void ShowMenu();
        void HandleUserInput(string userInput);
    }
}
