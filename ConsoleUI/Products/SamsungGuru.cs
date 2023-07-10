using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Abstract_Products;

namespace ConsoleUI.Products
{
    //Product
    internal class SamsungGuru : IiOS
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: N/A\nCamera: N/A";
        }
    }
}
