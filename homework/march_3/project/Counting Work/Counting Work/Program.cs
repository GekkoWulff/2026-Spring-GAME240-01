
//Write out numbers one to five by one
int number;
number = 1;

while (number <= 5)
{
    Console.WriteLine(number);
    number = number + 1;
}

//write a loop that counts 100 to 150
number = 100;

while (number <= 150)
{
    Console.WriteLine(number);
    number = number + 1;
}

//write a loop counting even numbers 0-100
number = 0;

while (number <= 100)
{
    Console.WriteLine(number);
    number = number + 2;
}

//write a loop that counts down from 20 to -20
number = 20;

while (number >= -20)
{
    Console.WriteLine(number);
    number = number - 1;
}

//write a loop that counts from 1-100 by 3
number = 1;
while (number <= 100)
{
    Console.WriteLine(number);
    number = number + 3;
}

//write a loop that counts 1 to 1024 exponentially by 2
number = 1;
while (number <= 1024)
{
    Console.WriteLine(number);
    number = number * 2;
}

//write a do-while loop that runs until the user says they want to stop
number = 1;
string answer;

do
{
    Console.WriteLine(number);
    number = number + 1;
    Console.WriteLine("Do you want the loop to stop?");
    answer = Console.ReadLine();

} while (answer == "No");

//write a while loop that cycles between true and false
/* int yesItIs = 1;
bool isItTrue = true;

while (yesItIs <= 10)
{
    Console.WriteLine(yesItIs);
    yesItIs = yesItIs + 1;
    if (yesItIs == true)
    {
        Console.WriteLine("True");
        isItTrue = false;
    }
    else if (yesItIs == false)
    {
        Console.WriteLine("It's Even");
        isItTrue = true;
    }
}
*/
do
{
    Console.WriteLine("True");
    Console.WriteLine("False");
    Console.WriteLine("True");
    Console.WriteLine("False");
    Console.WriteLine("True");
    Console.WriteLine("False");
    Console.WriteLine("Do you want to continue?");
    string endSequence = Console.ReadLine();
    if (endSequence == "No")
    {
        break;
    }
} while (true);