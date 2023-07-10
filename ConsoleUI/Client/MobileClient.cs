using ConsoleUI.Abstract_Factory;
using ConsoleUI.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Client
{
    internal class MobileClient
    {
        IAndroid androidPhone;
        IiOS iOSPhone;

        public MobileClient(IMobile factory)
        {
            androidPhone = factory.GetAndroidPhone();
            iOSPhone = factory.GetiOSPhone();
        }

        public string GetAndroidPhoneDetails()
        {
            return androidPhone.GetModelDetails();
        }

        public string GetiOSPhoneDetails()
        {
            return iOSPhone.GetModelDetails();
        }
    }
}
