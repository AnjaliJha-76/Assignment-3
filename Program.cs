using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3rd
{
    internal class Program
    {
       
       
            static void Main(string[] args)
            {
            //Employee.salary();
                // Create a bank account instance with an initial balance
                BankAccount account = new BankAccount("123456789", "John Doe", 1000);

                // Display initial account details
                Console.WriteLine(account.GetAccountDetails());

                // Deposit money
                account.Deposit(500);

                // Withdraw money
                account.Withdraw(300);

                // Attempt to withdraw more money than available
                account.Withdraw(1500);

                // Display final account details
                Console.WriteLine(account.GetAccountDetails());
            Console.ReadLine();

            }
    }
}
