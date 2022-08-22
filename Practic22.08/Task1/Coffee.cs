using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal class Coffee : IDrink
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "Кофе";
        public bool Temp { get; set; } = true;
    }
}