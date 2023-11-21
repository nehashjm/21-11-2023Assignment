using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace conappoverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            herbalproducts hb = new herbalproducts();
            //hb.ShowDetails();
            hb.SetInformation();
            hb.ShowDetails();
            Console.ReadKey();
        }
    }
}
