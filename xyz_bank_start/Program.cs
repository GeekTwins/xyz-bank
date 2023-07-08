using xyz_bank;
using System.Security.Principal;

var bank = new Bank();
var checkingAccount = new Account(Account.CHECKING);
var savingsAccount = new Account(Account.SAVINGS);
var maxiSavingsAccount = new Account(Account.MAXI_SAVINGS);

var henry = new Customer("Henry").OpenAccount(checkingAccount).OpenAccount(savingsAccount).OpenAccount(maxiSavingsAccount);
bank.AddCustomer(henry);

checkingAccount.Deposit(100.0);
savingsAccount.Deposit(1200.0);

savingsAccount.Withdraw(100.0);
maxiSavingsAccount.Withdraw(100);


var interest = bank.totalInterestPaid();
Console.WriteLine($"Total interest for {henry.GetName()}: {interest}");
Console.Write(henry.GetStatement());
