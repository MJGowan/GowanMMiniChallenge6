//Maddie Gowan
//10-18-2022
//Mini Challenge 6 - Redo
//In this program the user enters a number and the console must repeat back
//whether it is even or odd.

//Peer Reviewed by Griffin Parker
//This program works well, and does exactly as it is supposed to. It takes the
//user's input, validates that the input is a valid number, and then tells the
//user if their number is even or odd. It then lets the user decide to play
//again or quit out of the program. The restart function has some quirks however.
//It asks if you want to play again and to say 'no' if you don't. if you type
//yes, then it loops, but if you type anything other than yes or no, it will say
//"invalid response" yet still loop correctly.


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
