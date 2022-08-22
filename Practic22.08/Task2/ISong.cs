using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task2
{
    public interface ISong
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateOnly Date { get; set; }
        public string TextSong { get; set; }
    }
}
