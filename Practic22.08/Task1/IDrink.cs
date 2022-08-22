using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task1
{
    internal interface IDrink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Temp { get; set; }

    }
}
