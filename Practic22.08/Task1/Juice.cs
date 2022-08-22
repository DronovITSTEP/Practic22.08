using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class Juice : IDrink
    {
        public int ID { get; set; } = 2;
        public string Name { get; set; } = "Сок";
        public bool Temp { get; set; } = false;
    }
}
