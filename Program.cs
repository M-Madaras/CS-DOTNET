// test bank program
Console.WriteLine("Welcome to Bank BocaCode!!!");

BankAccount account = new BankAccount();
account.AccountNumber ="12345";

account.MakeDeposit(100);

BankAccount account2 = new SavingAccount(500);

try {
decimal newBalance = account2.MakeDepositGetBalance(-1);
} catch(Exception ex) {
    Console.WriteLine($"we got an error when running MakeDepositGetBalance(-1) ");
}
Console.WriteLine($"The Balance of Account is {account.Balance}");
Console.WriteLine($"The Account number of account is {account.AccountNumber}");

Console.WriteLine($"The Balance of Savings is {account2.Balance}");
