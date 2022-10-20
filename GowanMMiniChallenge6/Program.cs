//Maddie Gowan
//10-18-2022
//Mini Challenge #6 - Odd or Even
//This is a redo of an old assignment
Console.Clear();

bool playGame = true;

while (playGame)
{
    long num;
    Console.WriteLine("Pick a number and I will tell you whether it is odd or even");
    string input = Console.ReadLine();
    bool validNum = long.TryParse(input, out num);

    if (validNum)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("This number is even!");
        }
        else
        {
            Console.WriteLine("This number is odd!");
        }

        Console.WriteLine("Would you like to play again? If not, just say no");
        string result = Console.ReadLine();

        if (result == "no" || result == "No" || result == "NO")
        {
            playGame = false;
            Console.WriteLine("Okay, goodbye");
        }
        else if (result == "yes" || result == "Yes" || result == "YES")
        {
            playGame = true;
        }
        else{
            Console.WriteLine("Invalid response");
        }
    }
    else
    {
        Console.WriteLine("Invalid number");
    }


}
