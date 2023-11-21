using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conappoverride
{
    public class Products
    {
        int Pid;
        int PPrice;
        string Pname;
        public Products() 
        {
            Console.WriteLine("products constructor");
            
        }
        public virtual void SetInformation()
        {
            Pid = 11;
            Console.WriteLine("enter product name");
            Pname = Console.ReadLine();
            Console.WriteLine("enter Product price");
            PPrice = int.Parse(Console.ReadLine());
        }
        public virtual void ShowDetails() 
        {
            Console.WriteLine("Product id"+Pid);
            Console.WriteLine("Product name" + Pname);
            Console.WriteLine("Product Price" + PPrice);
        }
    }
}
