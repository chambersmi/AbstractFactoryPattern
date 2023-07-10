using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Abstract_Products;

namespace ConsoleUI.Abstract_Factory
{
    //Abstract Factory
    internal interface IMobile
    {
        IAndroid GetAndroidPhone();
        IiOS GetiOSPhone();

    }
}
