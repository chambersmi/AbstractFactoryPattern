using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Abstract_Factory;
using ConsoleUI.Abstract_Products;
using ConsoleUI.Products;

namespace ConsoleUI.Concrete_Factory
{
    //Concrete Factory
    internal class Samsung : IMobile
    {
        public IAndroid GetAndroidPhone()
        {
            return new SamsungGalaxy();
        }

        public IiOS GetiOSPhone()
        {
            return new SamsungGuru();
        }
    }
}
