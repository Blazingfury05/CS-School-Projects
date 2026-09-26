double checking_account = 420.69;
double saving_account = 2319.72;
Console.WriteLine("Welcome! What would you like to do today? \n Check balance? \n \t Withdraw from an account? \n \t \t \t \t Make a deposit? \n \t \t \t \t \t \t Transfer? ");
// Set all possible input combos

string account_choice = Console.ReadLine();

if (account_choice == "checking account" || account_choice == "checking" || account_choice == "check" || account_choice == "Checking account" || account_choice == "Checking Account" || account_choice == "Checking" ||
    account_choice == "check" || account_choice == "Check Balance" || account_choice == "Chceck balance" || account_choice == "check balance" || account_choice == "Balance" || account_choice == "balance")

    Console.WriteLine("Which account would you like to check? \n \t Checking? \t Saving?");
    string choice = Console.ReadLine();

if (choice == "checking account" || choice == "Checking account" || choice == "Checking Account" || choice == "checkings account" || choice == "Checkings Account" || choice == "Checkings" || choice == "checkings")
{

    Console.WriteLine(checking_account);
}
if (choice == "saving acount" || choice == "Saving account")
{
    Console.WriteLine(saving_account);
}

