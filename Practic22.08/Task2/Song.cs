using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task2
{
    /*
■ Название песни;
■ Исполнитель;
■ Год выпуска;
■ Текст песни.
    */
    public class Song : ISong
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Ели мясо мужики";
        public string Author { get; set; } = "Король и шут";
        public DateOnly Date { get; set; } = new DateOnly(1997, 4, 7);
        public string TextSong { get; set; } = "Ели мясо мужики, пивом запивали";
    }
}
