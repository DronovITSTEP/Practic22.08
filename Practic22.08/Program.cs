using Ninject;
using Practic22._08.Task1;
using Practic22._08.Task2;
using Autofac;

/*
 Разработайте иерархию классов напитков. Например:
чай, кофе, сок и т.д. Реализуйте методы для получения
информации о напитке. Предусмотрите отображение, как
на экран, так и в файл. Используйте при работе с этим
проектом Autofac или Ninject.


IKernel kernel = new StandardKernel(new DrinkModule());
var drink = kernel.Get<InformationDrink>();

drink.Info();
drink.InfoById(1);
drink.SaveFile();
drink.SaveFile(2);
*/

/*
Создайте класс для хранения информации о песне.
Нужно хранить такие данные:
■ Название песни;
■ Исполнитель;
■ Год выпуска;
■ Текст песни.
Информацию о песне можно отображать на экран или
в файл. Отображение может производиться в обычном
виде или с помощью азбуки Морзе.
Используйте при работе с этим проектом Autofac или
Ninject.
*/
var builder = new ContainerBuilder();
builder.RegisterType<Song>().As<ISong>();
builder.RegisterType<MethodSong>().As<IMethodSong>();

using (IContainer container = builder.Build())
{
    var song = container.Resolve<IMethodSong>();
    Console.WriteLine(song.GetAllSong());
    Console.WriteLine("\n\n");
    Console.WriteLine(song.GetSongByMorze(song.GetAllSong()));
}

