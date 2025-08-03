class Program
{
    public static void Main(string[] args)
    {
        /**Ask user inputs for
            1) Create a new bank account with an initial balance 
            2) Deposit money into the account
            3) Withdraw money from the account
            4) Balance inquiry
            5) Exit the program
        **/
        Console.WriteLine("Welcome to the Bank Account Management System!");
        //give options to choose from
        Console.WriteLine("1. Create a new bank account");
        Console.WriteLine("2. Deposit money");
        Console.WriteLine("3. Withdraw money");
        Console.WriteLine("4. Check balance");
        Console.WriteLine("5. Exit");
        Console.Write("Please select an option (1-5): ");

        string choice = Console.ReadLine();
        Console.WriteLine("You selected option: " + choice);

        //ask options from user until he press 5 to exit
        BankAccount account = null;

        
        while (choice != "5")
        {
            switch (choice)
            {
                case "1":
                    //handle null reference for account
                    if (account != null)
                    {
                        Console.WriteLine("A bank account already exists. Please choose another option.");
                        break;
                    }                    
                    Console.Write("Enter initial balance: ");
                    decimal initialBalance;
                    if (decimal.TryParse(Console.ReadLine(), out initialBalance))
                    {
                        account = new BankAccount(initialBalance);
                        Console.WriteLine($"Bank account created with initial balance: {account.Balance:C}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for initial balance.");
                    }
                    break;

                case "2":
                    if (account == null)
                    {
                        Console.WriteLine("Please create a bank account first.");
                    }
                    else
                    {
                        Console.Write("Enter amount to deposit: ");
                        decimal depositAmount;
                        if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for deposit amount.");
                        }
                    }
                    break;

                case "3":
                    if (account == null)
                    {
                        Console.WriteLine("Please create a bank account first.");
                    }
                    else
                    {
                        Console.Write("Enter amount to withdraw: ");
                        decimal withdrawAmount;
                        if (decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for withdrawal amount.");
                        }
                    }
                    break;

                case "4":
                    if (account == null)
                    {
                        Console.WriteLine("Please create a bank account first.");
                    }
                    else
                    {
                        Console.WriteLine($"Current balance: {account.Balance:C}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select a valid option (1-5).");
                    break;
            }

            // Display the menu again after processing the choice
            Console.WriteLine("\n1. Create a new bank account");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Check balance");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option (1-5): ");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Thank you for using the Bank Account Management System. Goodbye!");
        


    }
}