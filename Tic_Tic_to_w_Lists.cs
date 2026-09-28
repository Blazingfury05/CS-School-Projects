
string[] tictacboard = {" [0] "," [1] "," [2] \n "," [3] "," [4] "," [5] \n "," [6] "," [7] "," [8] \n "};

static void PrintBoard(string[] tictacboard)
{
    Console.Write(tictacboard[0]);
    Console.Write(tictacboard[1]);
    Console.WriteLine(tictacboard[2]);

    Console.Write(tictacboard[3]);
    Console.Write(tictacboard[4]);
    Console.WriteLine(tictacboard[5]);

    Console.Write(tictacboard[6]);
    Console.Write(tictacboard[7]);
    Console.WriteLine(tictacboard[8]);
}
Console.WriteLine("Hello, and welcome to Tic Tac To! what is Player 1's name?");
string player1 = Console.ReadLine();
Console.WriteLine($"Great to meet you {player1}, and who is Player2?");
string player2 = Console.ReadLine();
Console.WriteLine($"Great having you as well {player2}, now lets begin!");
Console.WriteLine("You will Press the number key associated with your desired spot to play your turn");

for (int i = 10; i > 0; i--)
{
PrintBoard(tictacboard);
Console.WriteLine("Choose a Cell");

string token = "X";

string move = Console.ReadLine();
int moveNumber = int.Parse(move);

tictacboard[moveNumber] = token;



//string token = "O" I can't make it that simple but it is the idea
};

// cats game, declaration of winner, etc happen after the loop

