using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal interface IMethodDrink
    {
        List<string> ShowDrink();
        string GetDrinkById(int id);
        List<string> ShowTempOfDrink();
    }
}
