Console.WriteLine("Hello Adventurer!");
Console.WriteLine(
    "You have found yourself in the extraordinary land of Zorp, a fantastical realm filled with monsters, mayhem, and a dragon most foul!");
Console.WriteLine("Mystery, battles and adventures await!");

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

void TakeAnItem(string item)
{
    if (item == "sword")
    {
        Console.WriteLine("You have found a Rusted Sword! It should work fine for your purposes, Adventurer.");
    }
    else if (item == "bow")
    {
        Console.WriteLine("You have found a Rotted Bow! It will serve your purposes well, Adventurer.");
    }
    else if (item == "shield")
    {
        Console.WriteLine("You have found a Rusted Shield! It will serve your purposes well, Adventurer.");
    }
    else if (item == "greatsword")
    {
        Console.WriteLine("A Greatsword! A noble warrior once wielded such a blade to slay a fearsome dragon!");
    }
    else if (item == "greatshield")
    {
        Console.WriteLine("A Greatshield! A noble warrior once wielded such protection to slay a fearsome dragon!");
    }
    else if (item == "greatbow")
    {
        Console.WriteLine("A Greatbow! A nobel warrior once wielded such a bow to slay a fearsome dragon!");
    }
    else
    {
        Console.WriteLine("I am afraid you cannot take that, Adventurer");
    }
}


(string name, int currentDurability)[] allMyWeapons = 
{
    ("sword", 3), ("bow", 2), ("shield", 2), ("greatsword", 5), ("greatbow", 5), ("greatshield", 5)
};

string hitTheBastard = "";

void UseAnItem((string name, int currentDurability) myWeapon)
{
    if (myWeapon.name == "sword")
    {
        UseAnItem(allMyWeapons[0]);
        Console.WriteLine("You use the Rusted Sword! It swings and wounds the enemy deeply.");
        myWeapon.currentDurability = myWeapon.currentDurability - 1;
        Console.WriteLine("You have " + myWeapon.currentDurability + " durability left on your sword");
        if (myWeapon.currentDurability == 0)
        {
            Console.WriteLine("Oh dear! Your sword broke!");
            //can no longer use that weapon
        }
    }
    else if (myWeapon.name == "bow")
    {
        UseAnItem(allMyWeapons[1]);
        Console.WriteLine("You use the Rotted Bow! It pierces your enemy's hide with ease.");
        //myWeapon.currentDurability[0] - 1
            if (myWeapon.currentDurability == 0)
            {
                Console.WriteLine("Oh dear! Your bow broke!");
                //can no longer use that weapon
            }
    }
    else if (myWeapon.name == "shield")
    {
        UseAnItem(allMyWeapons[2]);
        Console.WriteLine("You use the Rusted Shield! It bludgeons the enemy with a terrific clang.");
            //myWeapon.currentDurability[0] - 1
            if (myWeapon.currentDurability == 0)
            {
                Console.WriteLine("Oh dear! Your shield broke!");
                //can no longer use that weapon
            }
    }
    else if (myWeapon.name == "greatsword")
    {
        UseAnItem(allMyWeapons[3]);
        Console.WriteLine("You use the Greatsword! It cleaves through the enemy with ease.");
            //myWeapon.currentDurability[0] - 1
            if (myWeapon.currentDurability == 0)
            {
                Console.WriteLine("Oh dear! Your sword broke!");
                //can no longer use that weapon
            }
    }
    else if (myWeapon.name == "greatshield")
    {
        UseAnItem(allMyWeapons[4]);
        Console.WriteLine("You use the Greatshield! It deflects the enemy blows with ease.");
            //myWeapon.currentDurability[0] - 1
            if (myWeapon.currentDurability == 0)
            {
                Console.WriteLine("Oh dear! Your sword broke!");
                //can no longer use that weapon
            }
    }
    else if (myWeapon.name == "greatbow")
    {
        UseAnItem(allMyWeapons[5]);
        Console.WriteLine("You use the Greatbow! WRITE THIS DIALOGUE LATER");
        //myWeapon.currentDurability[0] - 1
        if (myWeapon.currentDurability == 0)
        {
            Console.WriteLine("Oh dear! Your sword broke!");
            //can no longer use that weapon
        }
    }
    else
    {
        Console.WriteLine("I am afraid you cannot use that here, Adventurer");
    }
}


string[] monsterName = { "Orc", "Goblin", "Bugbear", "Dragon"};
string coordinateSystemPlaceholder;


//combat system activation relies on coordinate system
//if in certain coordinate location, activate battle loop.
//when enemy is dead, stop battle loop. 
void EnterCombat(string rollInitiative)
{
    if (rollInitiative == "fight")
    {
        Console.WriteLine("Prepare for battle!");
        if (coordinateSystemPlaceholder == monsterName[0]) //if the coordinates match up, put monster 0, etc.
        {
            Console.WriteLine("You face off against the fearsome " + monsterName[0] + "!");
        }
        else if (coordinateSystemPlaceholder == monsterName[1]) //if the coordinates match up, put monster 0, etc.
        {
            Console.WriteLine("You face off against the fearsome " + monsterName[1] + "!");
        }
        else if (coordinateSystemPlaceholder == monsterName[2]) //if the coordinates match up, put monster 0, etc.
        {
            Console.WriteLine("You face off against the fearsome " + monsterName[2] + "!");
        }
        else if (coordinateSystemPlaceholder == monsterName[3]) //if the coordinates match up, put monster 0, etc.
        {
            Console.WriteLine("You face off against the fearsome " + monsterName[3] + "!");
        }
    }
}

/*else if (command == "use")
{
    Console.WriteLine("What do you want to use?");
    additionalInfo = Console.ReadLine();
    additionalInfo = additionalInfo.ToLower();
    if (additionalInfo == "sword")
    {
            
    }
    //create a place for user to type in their items 
    //make an inventory in a separate file system and then access it from there
    
    */

bool rollToHit = false;
while (rollToHit == true)
{
    string yourMove;
    string enemyMove;
}

//attack function with currentWeapon as argument 
//if sword
//store durability in a separate 
//only save when closing/autosave; put an array 

/*
(string name, int currentDurability)[] allMyWeapons; 
 
 
 myWeapon.name = "sword" 
 myWeapon.currentCapacity = 3
 
 */

Console.WriteLine("What would you like to do?");
string input; //stores whatever is from ReadLine
string command; //the action taken from ReadLine
string additionalInfo; //what it says on the tin; context for what the action will do

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
        //create an inventory/item collection array 
        //whenever command Take is used, add it to the inventory document 
        if (additionalInfo == "sword")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "shield")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "bow")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatsword")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatshield")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatbow")
        {
            TakeAnItem(additionalInfo);
        }
        else
        {
            Console.WriteLine("I'm afraid you cannot take that, Adventurer.");
        }
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
        //create an inventory/item collection array 
        //whenever command Take is used, add it to the inventory document 
        if (additionalInfo == "sword")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "shield")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "bow")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatsword")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatshield")
        {
            TakeAnItem(additionalInfo);
        }
        else if (additionalInfo == "greatbow")
        {
            TakeAnItem(additionalInfo);
        }
        else
        {
            Console.WriteLine("I'm afraid you cannot take that, Adventurer.");
        }
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
        EnterCombat(additionalInfo);
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

    