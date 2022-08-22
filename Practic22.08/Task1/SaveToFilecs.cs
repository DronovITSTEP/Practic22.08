using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class SaveToFilecs : IDrinkToFile
    {
        public void SaveDrink(string text)
        {
            string path = "C:/Files/drink.txt";
            File.AppendAllText(path, text);
        }
    }
}
