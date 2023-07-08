# RefactorThis
# Instructions
There are several deliberate design, code quality and test issues that should be identified and resolved. The section below details what the behavior of the application is supposed to be, which may not match up with how the code is currently functioning.

Fix broken (non-passing), incorrect, or incomplete tests.
Refactor as you see fit. Keep in mind that code quality is the critical measure and there should be an obvious focus on testing.
Treat this code as if you owned this application, do whatever you feel is necessary to make this your own.

# Application
A dummy application for a bank; should provide various functions of a retail bank.

Application is designed for Visual Studio 2017 or newer, MSTest as the testing framework (integrated into Visual Studio), and uses the .NET Framework v4.7.2. The solution is compatible with the community version.

# Current Features
* A customer can open an account.
* A customer can deposit / withdraw funds from an account.
* A customer can request a statement that shows transactions and totals for each of their accounts.
* Different accounts have interest calculated in different ways:
* Checking accounts have a flat rate of 0.1%.
* Savings accounts have a rate of 0.1% for the first $1,000 then 0.2%.
* Maxi-Savings accounts have a rate of 2% for the first $1,000 then 5% for the next $1,000 then 10%.
* A bank manager can get a report showing the list of customers and how many accounts they have.
* A bank manager can get a report showing the total interest paid by the bank on all accounts.
