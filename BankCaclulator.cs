double checking_account = 420.69;
double saving_account = 2319.72;
        Console.WriteLine("Welcome! What would you like to do today? \n Check balance? \n \t Withdraw from an account? \n \t \t \t \t Make a deposit? \n \t \t \t \t \t \t Transfer? ");
        // Set all possible input combos

        string account_choice = Console.ReadLine();

        if (account_choice == "checking account" || account_choice == "checking" || account_choice == "check" || account_choice == "Checking account" || account_choice == "Checking Account" || account_choice == "Checking" ||
            account_choice == "check" || account_choice == "Check Balance" || account_choice == "Chceck balance" || account_choice == "check balance" || account_choice == "Balance" || account_choice == "balance")
        {
            Console.WriteLine("Which account would you like to check? \n \t Checking? \t Saving?");
        }
        string choice = Console.ReadLine();

        if (choice == "checking account" || choice == "Checking account" || choice == "Checking Account" || choice == "checkings account" || choice == "Checkings Account" || choice == "Checkings" || choice == "checkings" || choice == "checking" || choice == "check" || choice == "Check")
        {

            Console.WriteLine(checking_account);
        }
        if (choice == "saving acount" || choice == "Saving account" || choice == "Saving Account" || choice == "saving" || choice == "Saving" || choice == "savings" || choice == "Savings" || choice == "savings account" || choice == "Savings account" || choice == "Savings Acount")
        {
            Console.WriteLine(saving_account);
        }

else if (account_choice == "Withdraw" || account_choice == "withdraw" || account_choice == "Withdrawn" || account_choice == "withdrawn" || account_choice == "withdraws" || account_choice == "Withdraws")
        {
            Console.WriteLine("Which account would you like withdraw from? \n \t Checking? \t Saving?");

        }
string withdrawchoice = Console.ReadLine();
if ( withdrawchoice == "checking account" || withdrawchoice == "Checking account" || withdrawchoice == "Checking Account" || withdrawchoice == "checkings account" || withdrawchoice == "Checkings Account" || withdrawchoice == "Checkings" || withdrawchoice == "checkings" || withdrawchoice == "checking" || withdrawchoice == "check" || withdrawchoice == "Check")
        {

            Console.WriteLine("How much would you like to withdraw?");
            double withdrawn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(checking_account - withdrawn);

        }
        if (withdrawchoice == "saving acount" || withdrawchoice == "Saving account" || withdrawchoice == "Saving Account" || withdrawchoice == "saving" || withdrawchoice == "Saving" || withdrawchoice == "savings" || withdrawchoice == "Savings" || withdrawchoice == "savings account" || withdrawchoice == "Savings account" || withdrawchoice == "Savings Acount")
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(saving_account - withdrawn);
        }