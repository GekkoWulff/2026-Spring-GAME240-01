// See https://aka.ms/new-console-template for more information
//Possible operations are addition(+) subtraction(-) multiplication(*) division(/) 

Console.WriteLine("Hello!");
Console.WriteLine("Welcome to the Calculator!");
Console.WriteLine("First, I'd like to get to know you!");

string firstName, lastName;
Console.WriteLine("What is your first name?");
firstName = Console.ReadLine(); 
Console.WriteLine("What is your last name?");
lastName = Console.ReadLine();
bool doWeShareAName;
int namesShared;

if (firstName == "Lillian" && lastName == "Gren")
{
    Console.WriteLine("Hello, Creator!!!!");
}

else if (firstName == "Lillian" || lastName == "Gren")
{
    Console.WriteLine("We share a name! How cool is that?");
}

if (firstName != "Lillian")
{
    Console.WriteLine("Oh! Then what is your name?");
    string name = Console.ReadLine();
    Console.Write(name);
    Console.WriteLine("? Huh. Never heard that one before. Pleasure to meet you!");
}

Console.WriteLine("How can I help you today?");
Console.ReadLine();
Console.WriteLine("Of course!");

string numberOne, numberTwo; 
double a, b;
string operation;

//Parse converts text to int "10" -> 10
Console.WriteLine("Tell me, what is your first number?");
numberOne = Console.ReadLine();
a = double.Parse(numberOne); 
Console.WriteLine("Alright. Now, what is your second number?");
numberTwo = Console.ReadLine();
b = double.Parse(numberTwo); 
Console.WriteLine("What operation do you want to use?"); 
operation = Console.ReadLine();

double result;
result = 0;

if (operation == "addition")
{
    result = a + b; 
}
else if (operation == "subtraction")
{ 
    result = a - b; 
}
else if (operation == "multiplication")
{
    result = a * b; 
}
else if (operation == "division")
{
    result = a / b;
}
else if (operation == "What is the secret to the universe?")
{
    result = 42;
}
else
{
    Console.WriteLine("There was an error"); 
}

if (b == 0 && operation == "division")
{
    Console.WriteLine();
}

Console.WriteLine(result);

Console.WriteLine("Thanks for playing!");