using ConsoleUI.Abstract_Factory;
using ConsoleUI.Client;
using ConsoleUI.Concrete_Factory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMobile samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine(samsungClient.GetAndroidPhoneDetails());
            Console.WriteLine();
            Console.WriteLine(samsungClient.GetiOSPhoneDetails());

        }
    }
}