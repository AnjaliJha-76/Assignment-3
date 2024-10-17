using System;

namespace Assignment_3rd
{
    internal class BankAccount
    {
        // Properties
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        // Constructor to initialize the bank account details
        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New Balance: {Balance:C}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        // Method to return account details as a formatted string
        public string GetAccountDetails()
        {
            return $"Account Details:\n" +
                   $"Account Number: {AccountNumber}\n" +
                   $"Account Holder: {AccountHolderName}\n" +
                   $"Balance: {Balance:C}";
        }
    }

    
}
