Console.WriteLine("  \n Hello, \n \t Welcome, \n \t \t Legendary Challengers!!!");
Console.WriteLine("Player 1, please tell us your name?");
string player1 = Console.ReadLine();
Console.WriteLine("Player 2, please tell us your name?");
string player2 = Console.ReadLine();
Console.WriteLine($"Welcome, {player1} and {player2}, May the true dragon warrior succeed in the sacred match count.");
// around This will be the start of a 3 round loop

string newline = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
int player1Wins = 0;
int player2Wins = 0;

for (int i = 3; i > 0; i--)
{

    int player1choice = 0;
    //string player1input == Console.ReadLine()
    //string player2input == Console.ReadLine
    //still need to place above lines

    Console.WriteLine("\n \n Choose your Weapons!!! \n \t Rock \t\t Paper \t\t Scissors");

    string player1input = Console.ReadLine();

    if (player1input == "rock" || player1input == "Rock" || player1input == "r" || player1input == "R")
    {
        player1choice = 1;
    }
    else if (player1input == "paper" || player1input == "Paper" || player1input == "p" || player1input == "P")
    {
        player1choice = 2;
    }
    else if (player1input == "scissors" || player1input == "Scissors" || player1input == "s" || player1input == "S")
    {
        player1choice = 3;
    }



    if (player1choice == 1)
    {
        Console.WriteLine(newline);
    }
    else if (player1choice == 2)
    {
        Console.WriteLine(newline);
    }
    else if (player1choice == 3)
    {
        Console.WriteLine(newline);
    }
    Console.WriteLine("A true warriors selection. May we have another?");
    int player2choice = 0;
    string player2input = Console.ReadLine();
    if (player2input == "rock" || player2input == "Rock" || player2input == "r" || player2input == "R")
    {
        player2choice = 1;
    }
    else if (player2input == "paper" || player2input == "Paper" || player2input == "p" || player2input == "P")
    {
        player2choice = 2;
    }
    else if (player2input == "scissors" || player2input == "Scissors" || player2input == "s" || player2input == "S")
    {
        player2choice = 3;
    }
    {
        if (player2choice == 1)
            Console.WriteLine(newline);
    }
    if (player2choice == 2)
    {
        Console.WriteLine(newline);
    }
    else if (player2choice == 3)
    {
        Console.WriteLine(newline);
    }

    // compare all possible game states

    if ((player1choice == 1 && player2choice == 1))
    {
        Console.WriteLine("\n Two immortal dragons clash forever");
    }
    else if ((player1choice == 1 && (player2choice == 2)))
    {
        Console.WriteLine("\n The rock crushed and pasted into a beautiful dress for the paper");
        player2Wins++;
    }
    else if ((player1choice == 1 && player2choice == 3))
    {
        Console.WriteLine("\n The puny scissors clatter as seperated blades");
        player1Wins++;
    }
    else if ((player1choice == 2 && (player2choice == 2)))
    {
        Console.WriteLine("\n Good luck cheating off each other now");
    }
    else if (player1choice == 2 && (player2choice == 1))
    {
        Console.WriteLine("\n Poor Rock turned sedimantary");
        player1Wins++;
    }
    else if (player1choice == 2 && (player2choice == 3))
    {
        Console.WriteLine("\n The paper made for a beautiful snow");
        player2Wins++;
    }
    else if (player1choice == 3 && (player2choice == 2))
    {
        Console.WriteLine("\n To Shreds you say?.");
        player1Wins++;
    }
    else if (player1choice == 3 && (player2choice == 3))
    {
        Console.WriteLine("\n the blades unsure of their absolute value each left.");
    }
    else if (player1choice == 3 && (player2choice == 1))
    {
        Console.WriteLine("Hard Rock crushes thin steel");
        player2Wins++;
    }
}
Console.WriteLine($"DEBUG: {player1} wins = {player1Wins} out of 3");
Console.WriteLine($"DEBUG: {player2} wins = {player2Wins} out of 3");

Console.WriteLine("\n \n \t The sacred match count has been reached");
if (player1Wins > player2Wins)
{
    Console.WriteLine($"{player1} Has Proven themself the Dragon Warrior!");
}
else if (player2Wins > player1Wins)
{
    Console.WriteLine($"{player2} Has Proven themself the Dragon Warrior!");
}
else if (player1Wins == player2Wins)
{
    Console.WriteLine("The Dragon Warrior has not yet been chosen, the battle continues eternally!");
}
