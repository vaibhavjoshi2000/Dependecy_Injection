using System.Threading.Channels;

namespace WithoutDependencyInjection
{ 
    class Program1
    {
        class SavingAccount
        {
            public void ShowDetails()
            {
                Console.WriteLine("Details of Savings Account");
            }
        }

        class CurrentAccount
        {
           public void  ShowDetails()
            {
                Console.WriteLine("Details of Current Account");
            }
        }

        class Account
        {
            SavingAccount obj1 = new SavingAccount();
            CurrentAccount obj2 = new CurrentAccount();
            public void PrintDetails()
            {
                obj1.ShowDetails();
                obj2.ShowDetails();
            }
        }
        static void Main(string[] args)
        {
            Account obj3 = new Account();
            obj3.PrintDetails();
        }
    }
}
//--------------Learning----------------------------
// Account Class is highly dependent with CurrentAccount class and SavingAccpuntClass.
// If any of the class i.e CurrentAccount class or SavingAccpuntClass modify/deleted that will directly imapact to Account Class.
//In Other Words Account Class is tightly Coupled with CurrentAccount class and SavingAccpuntClass.
