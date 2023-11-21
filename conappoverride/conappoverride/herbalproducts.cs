using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conappoverride
{
    public class herbalproducts:Products
    {
        string herbsused;
        DateTime MfgDate;
        DateTime ExpDate;

        public herbalproducts()
        {
            Console.WriteLine("constructor is called");
        }
        public override void SetInformation()
        {
            base.SetInformation();
            Console.WriteLine("enter the herbs used");
            herbsused = Console.ReadLine();
            MfgDate = DateTime.Now;
            ExpDate = DateTime.Now;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("herbs used is " + herbsused);
            Console.WriteLine("date of manufacturing"+MfgDate.ToShortDateString());
            Console.WriteLine("date of expiry" + ExpDate.ToShortDateString());
        }
    }
}
