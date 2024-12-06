using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection_UsingConstructor
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
        private IAccount account; //IAccount is variable of Interface type & account is variable name
        public Account(IAccount accounts) //Parametrised Constructor
        {
            this.account = accounts;
        }
        public void PrintDetails()
        {
            account.PrintDetails();
        }

        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();// Here CurrentAccount object will be stored in ca Interface (IAccount type)
            IAccount sa = new SavingAccount();//Matlab Child object(SavingAccount()) ka reference hum parent(CurrentAccount()) pe store kar sakte hai.
            Account a1 = new Account(ca);
            Account a2 = new Account(sa);
            a1.PrintDetails();//Details of CurrentAccount will print
            a2.PrintDetails();//Details of SavingAccount will print
        }
    }
}


//--------------------Learning-----------------------
//Create Interface for achieving DI

//Now SavingAccount class & CurrentAccount class will Implement the Interface method means 
// these are child classes of Interface

//Create Account class which is not directly depend on SavingAccount class & CurrentAccount class
//But Account Class is depend on Interface.

//When Account class is dependent on Interface then you know child of Interface is SavingAccount class & CurrentAccount class.
//It means these two classes SavingAccount class & CurrentAccount class ka object pass karne ka kaam Interface karega humare Account class ko

//Matlab Interface humare dono classes ke object ko inject kar dega Account Class pe.

//Now Create Constructor for Account class jiske through hum apni Account class mein inject karenge woh object jiski jarourat hogi

//Here Account class is Client class, Interface is Injector,and SavingAccount & CurrentAccount class are Service
