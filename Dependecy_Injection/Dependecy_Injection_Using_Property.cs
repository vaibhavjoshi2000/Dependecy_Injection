using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection_Using_Property
{
  
        interface IAccount
        {
            public void PrintDetails();
        }
        class CurrentAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Current Account");
            }
        }
        class SavingAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Saving Account");
            }
        }
    class Account
    {
        public IAccount account { get; set; } //IAccount is variable of Interface type & account is property name
        
        public void AccountDetails()
        {
            account.PrintDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assigning specific account types
            Account sa = new Account();
            Account ca = new Account();

            // Call AccountDetails to print the details
            sa.account = new SavingAccount();//Here SavingAccount object reference will be stored in account property
            sa.AccountDetails(); //It will print Details of Saving Account
           ca.account = new CurrentAccount();
            ca.AccountDetails();//It will print Details of Current Account
        }
    }
    
}


   
   

     
