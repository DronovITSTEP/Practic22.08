using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class Tea : IDrink
    {
        public int ID { get; set; } = 3;
        public string Name { get; set; } = "Чай";
        public bool Temp { get; set; } = true;
    }
}
