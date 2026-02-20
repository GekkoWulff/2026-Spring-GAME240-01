int secretNumber;
secretNumber = 69;

Console.WriteLine("What is my secret number?");
int guess;
guess = int.Parse(Console.ReadLine());

while (guess != secretNumber)
{
    if (secretNumber < guess)
    {
        Console.WriteLine("Too high! Nice try buddy, better luck next time!");
    }
    else if (secretNumber > guess)
    {
        Console.WriteLine("Too low! So close!");
    }
    Console.WriteLine("What is my secret number?");
    guess = int.Parse(Console.ReadLine());
}

if (guess == secretNumber)
{
    Console.WriteLine("Congratulations! You won! Want to try again?");
}
    



