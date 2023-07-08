using xyz_bank;
using System.Security.Principal;

var bank = new Bank();
var checkingAccount = new Account(Account.CHECKING);
//var savingsAccount = new Account(Account.SAVINGS);

//var henry = new Customer("Henry").OpenAccount(checkingAccount).OpenAccount(savingsAccount);
var henry = new Customer("Henry").OpenAccount(checkingAccount);
bank.AddCustomer(henry);

checkingAccount.Deposit(100.0);
//savingsAccount.Deposit(4000.0);
//savingsAccount.Withdraw(200.0);


var interest = bank.totalInterestPaid();
Console.WriteLine($"Total interest for {henry.GetName()}: {interest}");
//Console.Write(henry.GetStatement());
