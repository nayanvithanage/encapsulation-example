using System;

//define a class to represent a Bank Account
public class BankAccount
{
    // Private field to store account balance, demonstrating data hiding
    private decimal _balance;

    //COnstructor to initialize the account with an Initial balance
    public BankAccount(decimal initialBalance)
    {
        if (initialBalance >= 0)
        {
            _balance = initialBalance;
        }
        else
        {
            Console.WriteLine("Initial balance cannot be negative. Setting to zero.");
            _balance = 0;
        }

    }

    //public properrty to get the current balance
    public decimal Balance
    {
        get { return _balance; }
    }

    //public method to deposit money, controlled access to _balance
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New balance: {_balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    //public method to withdraw funds
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
    
}