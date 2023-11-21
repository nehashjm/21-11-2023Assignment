using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConappAssignmentday12
{
    public class BankAccount
    {
        readonly int accountnumber;
        string accountholdername;
        int balance;
        int deposit;
        int withdraw;

        public BankAccount()
        {
            Console.WriteLine("Bank constructor");
            accountholdername = "avinash";
            balance = 0;
        }
        public void Deposit()
        {
            Console.WriteLine("enter the deposit anount");
            deposit = int.Parse(Console.ReadLine());
            balance = deposit + balance;
            Console.WriteLine("amount deposited " + deposit);
        }
        public void Withdraw()
        {
            Console.WriteLine("enter withdraw amount");
            withdraw = int.Parse(Console.ReadLine());
            balance = balance-withdraw;
            Console.WriteLine("amount withdrawn" + withdraw);
        }
        public void Display()
        {
            Console.WriteLine("account holder name" + accountholdername);
            Console.WriteLine("amount deposited"+deposit);
            Console.WriteLine("amount withdrawn"+withdraw);
            Console.WriteLine("account balance" + balance);
        }
    }
}
