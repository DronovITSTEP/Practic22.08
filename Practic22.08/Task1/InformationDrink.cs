using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class InformationDrink
    {
        private readonly IMethodDrink _methodDrink;
        private readonly IDrinkToFile _drinkToFile;
        public InformationDrink(IMethodDrink methodDrink, IDrinkToFile drinkToFile)
        {
            _drinkToFile = drinkToFile;
            _methodDrink = methodDrink;
        }
        public void Info()
        {
            for (int i = 0; i < _methodDrink.ShowDrink().Count; i++)
            {
                Console.WriteLine(_methodDrink.ShowDrink()[i] + " : " +
                    _methodDrink.ShowTempOfDrink()[i]);
            }
        }
        public void InfoById(int id) {
            Console.WriteLine(_methodDrink.GetDrinkById(id));
        }

        public void SaveFile(int id = -1)
        {   if (id == -1)
            {
                for (int i = 0; i < _methodDrink.ShowDrink().Count; i++)
                {
                    string str = _methodDrink.ShowDrink()[i] +
                        " : " + _methodDrink.ShowTempOfDrink()[i];
                    _drinkToFile.SaveDrink(str);
                }
            }
        else
            {
                _drinkToFile.SaveDrink(_methodDrink.GetDrinkById(id));
            }
        }

    }
}
