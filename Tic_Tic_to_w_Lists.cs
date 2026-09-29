
string[] tictacboard = {" [0]       "," [1]     "," [2]     \n "," [3]      "," [4]     "," [5]     \n "," [6]      "," [7]     "," [8]      \n "};
int[,] winconditions =
{
    { 0, 1, 2 },
    { 3, 4, 5 },
    { 6, 7, 8 },
    { 0, 3, 6 },
    { 1, 4, 7 },
    { 2, 5, 8 },
    { 0, 4, 8 },
    { 2, 4, 6 }
};

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

int player1Wins = 0;
int player2Wins = 0;

string token = "X";

static bool CheckWin(string[] board, string token, int[,] wincondtions)
{
    for (int i = 0; i < 8; i++)

    {
if (board[wincondtions[i, 0]] == token &&
    board[wincondtions[i,1]] == token &&
    board[wincondtions[i,2]] == token)
        {
return true;            
        }
    }

    return false;
}
// still need to add player(x) choice = 0 and assighn a player(x)choice++

for (double i = 4; i > 0; i--)
{

token = "X";

PrintBoard(tictacboard);
Console.WriteLine("Choose a Cell\n");

string move = Console.ReadLine();
int moveNumber = int.Parse(move);

tictacboard[moveNumber] = token;
if (CheckWin(tictacboard, token, winconditions))
{
        player1Wins++;
        Console.WriteLine($"{player1} wins!");
        break;
    }


token = "O";

PrintBoard(tictacboard);
Console.WriteLine("Choose a Cell\n");

move = Console.ReadLine();
moveNumber = int.Parse(move);

tictacboard[moveNumber] = token;

{
    if (CheckWin(tictacboard, token, winconditions))
{
        player2Wins++;
        Console.WriteLine($"{player2} wins!");
        break;
    }
}



};
token = "x";

PrintBoard(tictacboard);
Console.WriteLine("Choose a Cell\n");

string movef = Console.ReadLine();
int movefNumber = int.Parse(movef);

tictacboard[movefNumber] = token;
if (CheckWin(tictacboard, token, winconditions))
{
        player1Wins++;
        Console.WriteLine($"{player1} wins!");
    }
if (CheckWin(tictacboard, token, winconditions) == false)
{
Console.WriteLine("Cat scratch the board?");
}

// potentially add round system to make use of playerxWins++