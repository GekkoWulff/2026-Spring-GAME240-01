Console.WriteLine("Hello Adventurer!");
Console.WriteLine(
    "You have found yourself in the extraordinary land of Zorp, a fantastical realm filled with monsters, mayhem, and a dragon most foul!");

void MoveInDirection(string direction)
{
    if (direction == "north")
    {
        Console.WriteLine("You venture North");
    }
    else if (direction == "west")
    { 
        Console.WriteLine("You venture West");
    }
    else if (direction == "east")
    {
        Console.WriteLine("You venture East");
    }
    else if (direction == "south")
    {
        Console.WriteLine("You venture South");
    }
    else
    {
        Console.WriteLine("I'm afraid I do not know that route, Adventurer.");
    }
}


Console.WriteLine("What would you like to do?");
string command; //the actual action
string input; //stores whatever is from ReadLine
string additionalInfo; //what it says on the tin 

input = Console.ReadLine();
input = input.ToLower(); 
string[] splitInput = input.Split(" ");
command = splitInput[0];

try
{
    additionalInfo = splitInput[1];
    
    if (command == "move")
    {
        Console.WriteLine("Where do you want to go?");
        additionalInfo = Console.ReadLine();
        additionalInfo = additionalInfo.ToLower(); 
        //To do: handle movement in directions 
        if (additionalInfo == "north")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "west")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "east")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "south")
        {
            MoveInDirection(additionalInfo);
        }
        else
        {
            Console.WriteLine("I'm afraid I do not know that route, Adventurer."); 
        }
    }
    else if (command == "take")
    {
        Console.WriteLine("What do you want to take?");
        additionalInfo = Console.ReadLine();
        //create an inventory/item collection array 
        //whenever command Take is used, add it to the inventory document 
    }
    else if (command == "use")
    {
        Console.WriteLine("What do you want to use?");
        additionalInfo = Console.ReadLine();
        //create a place for user to type in their items 
        //make an inventory in a separate file system and then access it from there
    }
    else if (command == "jump")
    {
        Console.WriteLine("You jump. It does nothing.");
        additionalInfo = Console.ReadLine();
    }
    else if (command == "fight")
    {
        Console.WriteLine("You face off against the fearsome (monster)!");
        additionalInfo = Console.ReadLine();
    }

    else if (command == "enter")
    {
        Console.WriteLine("You enter the tavern.");
    }
    else
    {
        Console.WriteLine("I'm afraid I don't know what you're asking of me, Adventurer.");
    }
}

catch (Exception e)
{
    command = input;
    if (command == "move")
    {
        Console.WriteLine("Where do you want to go?");
        additionalInfo = Console.ReadLine();
        additionalInfo = additionalInfo.ToLower(); 
        //To do: handle movement in directions 
        if (additionalInfo == "north")
        {
            Console.WriteLine("You venture North");
        }
        else if (additionalInfo == "west")
        {
            Console.WriteLine("You venture West");
        }
        else if (additionalInfo == "east")
        {
            Console.WriteLine("You venture East");
        }
        else if (additionalInfo == "south")
        {
            Console.WriteLine("You venture South");
        }
        else
        {
            Console.WriteLine("I'm afraid I do not know that route, Adventurer."); 
        }
    }
    else if (command == "take")
    {
        Console.WriteLine("What do you want to take?");
        additionalInfo = Console.ReadLine();
        //create an inventory/item collection array 
    }
    else if (command == "use")
    {
        Console.WriteLine("What do you want to use?");
        additionalInfo = Console.ReadLine();
        //create a place for user to type in their items 
        //make an inventory in a separate file system and then access it from there
    }
    else if (command == "jump")
    {
        Console.WriteLine("You jump. It does nothing.");
        additionalInfo = Console.ReadLine();
    }
    else if (command == "fight")
    {
        Console.WriteLine("You face off against the fearsome (monster)!");
        additionalInfo = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("I'm afraid I don't know what you're asking of me, Adventurer.");
    }
}


/*
string state;
state = "basic mario";


switch (state)
{
    case "basic mario":
        Console.WriteLine("You're mini mario!");
        break;
    case "fire mario":
        break;
    case "mirror mario":
        break;
    case "cat mario":
        break;
    case "tanooki mario":
        break;

}
*/

Random grue = new Random();
grue.Next(0, 1000);
int grueNumber = grue.Next();
if(grueNumber == 198)
{
    //whatever grue code happens in here
    //reduce player health to 0
    Console.WriteLine("You have been eaten by a grue.");
}

    