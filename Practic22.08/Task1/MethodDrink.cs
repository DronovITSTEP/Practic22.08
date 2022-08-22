using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class MethodDrink : IMethodDrink
    {
        private readonly IDrink[] _drinks;

        public MethodDrink (IDrink[] drinks)
        {
            _drinks = drinks;
        }

        public List<string> ShowDrink()
        {
            List<string> str = new List<string>();
            foreach (var drink in _drinks)
                str.Add(drink.Name);
            return str;
        }
        public string GetDrinkById(int id)
        {
            return _drinks[id-1].Name + " : " + _drinks[id-1].Temp;
        }

        public List<string> ShowTempOfDrink()
        {
            List<string> str = new List<string>();
            foreach (var drink in _drinks)
                str.Add((drink.Temp) ? "горячий" : "холодный");
            return str;
        }
    }
}
