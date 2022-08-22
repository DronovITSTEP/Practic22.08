using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace Practic22._08.Task1
{
    internal class DrinkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDrink>().To<Coffee>();
            Bind<IDrink>().To<Tea>();
            Bind<IDrink>().To<Juice>();
            Bind<IMethodDrink>().To<MethodDrink>();
            Bind<IDrinkToFile>().To<SaveToFilecs>();
        }
    }
}
