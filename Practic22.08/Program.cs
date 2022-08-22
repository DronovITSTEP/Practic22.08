using Ninject;
using Practic22._08.Task1;

/*
 Разработайте иерархию классов напитков. Например:
чай, кофе, сок и т.д. Реализуйте методы для получения
информации о напитке. Предусмотрите отображение, как
на экран, так и в файл. Используйте при работе с этим
проектом Autofac или Ninject.
*/

IKernel kernel = new StandardKernel(new DrinkModule());
var drink = kernel.Get<InformationDrink>();

drink.Info();
drink.InfoById(1);
drink.SaveFile();
drink.SaveFile(2);
