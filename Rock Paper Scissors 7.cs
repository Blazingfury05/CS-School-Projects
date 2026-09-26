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

    Console.WriteLine("\n \n Choose your Weapons!!! \n \t Rock \t\t Paper \t\t Scissors \n \t Fire \t\t Sponge \t Water \t  air");

    string player1input = Console.ReadLine();

    if (player1input == "rock" || player1input == "Rock" || player1input == "r" || player1input == "R")
    {
        player1choice = 1;
    }
   else if (player1input == "paper" || player1input == "Paper" || player1input == "p" || player1input == "P")
    {
        player1choice = 2;
    }
   else if (player1input == "scissors" || player1input == "Scissors" || player1input == "sc" || player1input == "Sc" || player1input == "SC")
    {
        player1choice = 3;
    }
   else if (player1input == "Fire" || player1input == "fire" || player1input == "blaze" || player1input == "Blaze" || player1input == "f" || player1input == "F")
    {
        player1choice = 4;
    }
   else if (player1input == "Sponge" || player1input == "sponge" || player1input == "SP" || player1input == "sp" || player1input == "Sp")
    {
        player1choice = 5;
    } 
    else if (player1input == "Water" || player1input == "water" || player1input == "W" || player1input == "w" || player1input == "wet" || player1input == "Wet")
    {
        player1choice = 6;
    }
    else if (player1input == "Air" || player1input == "air" || player1input == "a" || player1input == "A" || player1input == "wind" || player1input == "Wind")
    {
        player1choice = 7;
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
    else if (player1choice == 4)
    {
        Console.WriteLine(newline);
    }
    else if (player1choice == 5)
    {
        Console.WriteLine(newline);
    }
    else if (player1choice == 6)
    {
        Console.WriteLine(newline);
    }
    else if (player1choice == 7)
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
    else if (player2input == "scissors" || player2input == "Scissors" || player2input == "sc" || player2input == "Sc" || player2input == "SC")
    {
        player2choice = 3;
    }
     else if (player2input == "Fire" || player2input == "fire" || player2input == "blaze" || player2input == "Blaze" || player2input == "f" || player2input == "F")
         {
        player2choice = 4;
    }
     else if (player2input == "Sponge" || player2input == "sponge" || player2input == "SP" || player2input == "sp" || player2input == "Sp")
    {
        player2choice = 5;
    } 
    else if (player2input == "Water" || player2input == "water" || player2input == "W" || player2input == "w" || player2input == "wet" || player2input == "Wet")
    {
        player2choice = 6;
    }
    else if (player2input == "Air" || player2input == "air" || player2input == "a" || player2input == "A" || player2input == "wind" || player2input == "Wind")
    {
        player2choice = 7;
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
    else if (player2choice == 4)
    {
        Console.WriteLine(newline);
    }
    else if (player2choice == 5)
    {
        Console.WriteLine(newline);
    }
    else if (player2choice == 6)
    {
        Console.WriteLine(newline);
    }
        else if (player2choice == 7)
    {
        Console.WriteLine(newline);
    }
    // compare all possible game states

    if (player1choice == 1 && player2choice == 1)
    {
        Console.WriteLine("\n Two immortal dragons clash forever");
    }
    else if (player1choice == 1 && (player2choice == 2))
    {
        Console.WriteLine("\n The rock crushed and pasted into a beautiful dress for the paper");
        player2Wins++;
    }
   else if ((player1choice == 1 && player2choice == 3))
    {
        Console.WriteLine("\n The puny scissors clatter as seperated blades");
        player1Wins++;
    }
   else if (player1choice == 1 && (player2choice == 4))
    {
        Console.WriteLine("\n Rock Snuffs out the flames");
         player1Wins++;
    }
    else if (player1choice == 1 && (player2choice == 5))
    {
        Console.WriteLine("\n Rock spills sponges soap");
         player1Wins++;
    }
  else if (player1choice == 1 && (player2choice == 6))
    {
        Console.WriteLine("\n The rock slowly forms a grand canyon");
         player1Wins++;
    }
  else if (player1choice == 1 && (player2choice == 7))
    {
        Console.WriteLine("\n Your chief stone flies off the stone stack ): ");
         player2Wins++;
    }
    else if (player1choice == 2 && (player2choice == 2))
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
    else if (player1choice == 2 && (player2choice == 4))
    {
       Console.WriteLine("\n The Paper turns to ash and sinders");
       player2Wins++;
    }
    else if (player1choice == 2 && (player2choice == 5))
    {
        Console.WriteLine("\n the paper loses its ink and eventually its form to the moisture ");
        player2Wins++;
    }
    else if (player1choice == 2 && (player2choice == 6))
    {
        Console.WriteLine("\n Your quick origami skills gave you a boat upon this sea ");
        player1Wins++;
    }
    else if (player1choice == 2 && (player2choice == 7))
    {
        Console.WriteLine("\n The paper was secretely a folded Skíðblaðnir!");
        player1Wins++;
    }
    else if (player1choice == 3 && (player2choice == 1))
    {
        Console.WriteLine("Hard Rock crushes thin steel");
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

    else if (player1choice == 3 && (player2choice == 4))
    {
        Console.WriteLine("the scissors smelt away");
        player1Wins++;
    }
    else if (player1choice == 3 && (player2choice == 5))
    {
        Console.WriteLine("more sponges but less absorbed water");
        player1Wins++;
    }
    else if (player1choice == 3 && (player2choice == 6))
    {
        Console.WriteLine("The metal turns a deep brown before forming holes and crumbling");
        player2Wins++;
    }
    else if (player1choice == 3 && (player2choice == 7))
    {
        Console.WriteLine("Like theres nothing even there");
        player1Wins++;
    }
    else if (player1choice == 4 && (player2choice == 1))
    {
        Console.WriteLine("the rock now can cook its own food");
        player2Wins++;
    }
    else if (player1choice == 4 && (player2choice == 2))
    {
        Console.WriteLine("Hope nothing important was on there...");
        player1Wins++;
    }
    else if (player1choice == 4 && (player2choice == 3))
    {
        Console.WriteLine("I don't think those are being picked back up");
        player1Wins++;
    }
    else if (player1choice == 4 && (player2choice == 4))
    {
        Console.WriteLine("YES LET THE BLAZE BURNNNNNNNN!!!!");
    }
    else if (player1choice == 4 && (player2choice == 5))
    {
        Console.WriteLine("Sorry not enough water to avoid a steaming");
        player1Wins++;
    }
    else if (player1choice == 4 && (player2choice == 6))
    {
        Console.WriteLine("Firefighters figured that out a long time ago");
        player2Wins++;
    }
    else if (player1choice == 4 && (player2choice == 7))
    {
        Console.WriteLine("Didn't burn bright enough to handle fanning");
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
